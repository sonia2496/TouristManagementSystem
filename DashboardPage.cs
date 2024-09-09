using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TouristManagement
{
    public partial class DashboardPage : Form
    {
        private string username;

        public DashboardPage(string username)
        {
            //setting up list view for bookings
            //setting up list view for payments
            InitializeComponent();
            this.username = username;
            SetupListViewBookings();
            SetupListViewPayments();
            LoadReservations();
            LoadPayments();

        }

        private void SetupListViewBookings()
        {
            //setting up columns for viewing bookings
            LstViewBookings.View = View.Details;
            LstViewBookings.Columns.Add("Reservation ID", 120);
            LstViewBookings.Columns.Add("Site Name", 200);
            LstViewBookings.Columns.Add("Reservation Date", 150);
            LstViewBookings.Columns.Add("Start Date", 150);
            LstViewBookings.Columns.Add("End Date", 150);
        }

        private void SetupListViewPayments()
        {
            //setting up columns for view paymentss
            LstViewPayments.View = View.Details;
            LstViewPayments.Columns.Add("Payment ID", 120);
            LstViewPayments.Columns.Add("Site Name", 200);
            LstViewPayments.Columns.Add("Amount", 100);
            LstViewPayments.Columns.Add("Payment Date", 150);
        }

        private void LoadReservations()
        {
            using (OracleConnection connection = DatabaseConnection.Instance.CreateConnection())
            {
                try
                {
                    connection.Open();

                    // Query for reservations
                    string reservationsQuery = "SELECT ReservationID, SiteName, ReservationDate, StartDate, EndDate FROM reservations WHERE Username = :username";

                    using (OracleCommand reservationsCommand = new OracleCommand(reservationsQuery, connection))
                    {
                        reservationsCommand.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;

                        using (OracleDataReader reservationsReader = reservationsCommand.ExecuteReader())
                        {
                            // Clearing the ListView before populating it
                            LstViewBookings.Items.Clear();
                            while (reservationsReader.Read())
                            {
                                ListViewItem item = new ListViewItem(reservationsReader["ReservationID"].ToString());
                                item.SubItems.Add(reservationsReader["SiteName"].ToString());
                                item.SubItems.Add(reservationsReader["ReservationDate"].ToString());
                                item.SubItems.Add(reservationsReader["StartDate"].ToString());
                                item.SubItems.Add(reservationsReader["EndDate"].ToString());

                                LstViewBookings.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void LoadPayments()
        {
            using (OracleConnection connection = DatabaseConnection.Instance.CreateConnection())
            {
                try
                {
                    connection.Open();

                    // Query for payments
                    string paymentsQuery = "SELECT PaymentID, SiteName, Amount, PaymentDate FROM PaymentHistory WHERE Username = :username";

                    using (OracleCommand paymentCommand = new OracleCommand(paymentsQuery, connection))
                    {
                        paymentCommand.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;

                        using (OracleDataReader paymentsReader = paymentCommand.ExecuteReader())
                        {
                            // Clearing the ListView before populating it
                            LstViewPayments.Items.Clear();
                            while (paymentsReader.Read())
                            {
                                ListViewItem item = new ListViewItem(paymentsReader["PaymentID"].ToString());
                                item.SubItems.Add(paymentsReader["SiteName"].ToString());
                                item.SubItems.Add(paymentsReader["Amount"].ToString());
                                item.SubItems.Add(paymentsReader["PaymentDate"].ToString());

                                LstViewPayments.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        public DataTable GetCombinedHistory()
        {
            DataTable combinedTable = new DataTable();
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();

                    // Fetching the reservation data from database
                    DataTable reservationTable = new DataTable();
                    string reservationQuery = "SELECT ReservationID, SiteName, StartDate, EndDate FROM Reservations WHERE UserName = :username";
                    using (var reservationCmd = new OracleCommand(reservationQuery, conn))
                    {
                        reservationCmd.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;

                        using (var reservationAdapter = new OracleDataAdapter(reservationCmd))
                        {
                            reservationAdapter.Fill(reservationTable);
                        }
                    }

                    // Fetching payment data from database
                    DataTable paymentTable = new DataTable();
                    string paymentQuery = "SELECT PaymentID, SiteName, Amount, PaymentDate FROM PaymentHistory WHERE UserName = :username";
                    using (var paymentCmd = new OracleCommand(paymentQuery, conn))
                    {
                        paymentCmd.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;

                        using (var paymentAdapter = new OracleDataAdapter(paymentCmd))
                        {
                            paymentAdapter.Fill(paymentTable);
                        }
                    }

                    // Combining the tables
                    combinedTable.Columns.Add("Username");
                    combinedTable.Columns.Add("ReservationID");
                    combinedTable.Columns.Add("SiteName");
                    combinedTable.Columns.Add("StartDate");
                    combinedTable.Columns.Add("EndDate");
                    combinedTable.Columns.Add("PaymentID");
                    combinedTable.Columns.Add("Amount");
                    combinedTable.Columns.Add("PaymentDate");

                    foreach (DataRow reservationRow in reservationTable.Rows)
                    {
                        DataRow newRow = combinedTable.NewRow();
                        newRow["Username"] = username;
                        newRow["ReservationID"] = reservationRow["ReservationID"];
                        newRow["SiteName"] = reservationRow["SiteName"];
                        newRow["StartDate"] = reservationRow["StartDate"];
                        newRow["EndDate"] = reservationRow["EndDate"];


                        DataRow[] matchingPayments = paymentTable.Select($"SiteName = '{reservationRow["SiteName"]}'");
                        if (matchingPayments.Length > 0)
                        {
                            newRow["PaymentID"] = matchingPayments[0]["PaymentID"];
                            newRow["Amount"] = matchingPayments[0]["Amount"];
                            newRow["PaymentDate"] = matchingPayments[0]["PaymentDate"];
                        }

                        combinedTable.Rows.Add(newRow);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return combinedTable;
        }

        public void ExportToCsv(DataTable dataTable)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog.Title = "Save an Exported CSV File";
                saveFileDialog.FileName = "Report.csv"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    using (var writer = new StreamWriter(filePath))
                    {
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            writer.Write(dataTable.Columns[i].ColumnName);
                            if (i < dataTable.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        foreach (DataRow row in dataTable.Rows)
                        {
                            for (int i = 0; i < dataTable.Columns.Count; i++)
                            {
                                writer.Write(row[i].ToString());
                                if (i < dataTable.Columns.Count - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();
                        }
                    }
                    MessageBox.Show("CSV file has been successfully saved!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            //fetching the combined data and then calling the export method to generate a file in csv format
            DataTable dataTable = GetCombinedHistory();
            ExportToCsv(dataTable);
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            //redirecting to form1 page on clicking logout button
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void BtnMakeAnotherreservation_Click(object sender, EventArgs e)
        {
            //redirecting to reservation page on clicking make another reservation
            Reservationpage reservationpage = new Reservationpage(UserSession.username);
            reservationpage.Show();
            this.Hide();
        }

        private void LstViewBookings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
