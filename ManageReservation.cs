using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace TouristManagement
{
    public partial class ManageReservation : Form
    {
        private string username;

        public ManageReservation(string username)
        {
            //Loading the reservationss
            InitializeComponent();
            this.username = username;
            LoadReservations();
        }
         
        //loading reservation from reservation table into combo box
        private void LoadReservations()
        {
            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var conn = dbConnection.CreateConnection())
                {
                    conn.Open();

                    string query = @"
            SELECT ReservationID, SiteName
            FROM Reservations
            WHERE Username = :Username";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Username", OracleDbType.Varchar2)).Value = username;

                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new DataTable();
                            dt.Load(reader);

                            // Verifying the DataTable contents
                            foreach (DataRow row in dt.Rows)
                            {
                                Console.WriteLine($"ReservationID: {row["ReservationID"]}, SiteName: {row["SiteName"]}");
                            }

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No reservations found.");
                                cmbMyReservations.DataSource = null; 
                            }
                            else
                            {
                             
                                cmbMyReservations.DataSource = null;
                                cmbMyReservations.DisplayMember = "SiteName";
                                cmbMyReservations.ValueMember = "ReservationID";
                                cmbMyReservations.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading reservations: {ex.Message}");
            }
        }


        //loading reservation dates from reservation table into combo box
        private void LoadReservationDates(int reservationId)
        {
            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var conn = dbConnection.CreateConnection())
                {
                    conn.Open();

                    string query = @"
                            SELECT StartDate, EndDate
                            FROM Reservations
                            WHERE ReservationID = :ReservationID";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("ReservationID", OracleDbType.Decimal)).Value = reservationId;

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // check StartDate and EndDate are not DBNull
                                if (!reader.IsDBNull(reader.GetOrdinal("StartDate")))
                                {
                                    DtpCurrentStartDate.Value = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                                }

                                if (!reader.IsDBNull(reader.GetOrdinal("EndDate")))
                                {
                                    DtpCurrentEndDate.Value = reader.GetDateTime(reader.GetOrdinal("EndDate"));
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for the selected reservation.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading reservation dates: {ex.Message}");
            }
        }

        //updating the existing reservation data
        private void BtnUpdateReservation_Click(object sender, EventArgs e)
        {
            if (cmbMyReservations.SelectedValue == null)
            {
                MessageBox.Show("No reservation selected.");
                return;
            }

       
            int reservationId;

           
            if (cmbMyReservations.SelectedValue is decimal reservationDecimal)
            {
                reservationId = Convert.ToInt32(reservationDecimal);
            }
            else
            {
                MessageBox.Show("Invalid reservation ID.");
                return;
            }

            DateTime startDate = DtpNewStartDate.Value;
            DateTime endDate = DtpNewEndDate.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("End Date must be greater than or equal to Start Date.");
                return;
            }

            if (startDate < DateTime.Now.Date || endDate < DateTime.Now.Date)
            {
                MessageBox.Show("Dates cannot be in the past.");
                return;
            }

            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var conn = dbConnection.CreateConnection())
                {
                    conn.Open();

                    string updateQuery = @"
                         UPDATE Reservations
                         SET StartDate = :StartDate, EndDate = :EndDate
                        WHERE ReservationID = :ReservationID";

                    using (var cmd = new OracleCommand(updateQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("StartDate", OracleDbType.Date)).Value = startDate;
                        cmd.Parameters.Add(new OracleParameter("EndDate", OracleDbType.Date)).Value = endDate;
                        cmd.Parameters.Add(new OracleParameter("ReservationID", OracleDbType.Decimal)).Value = reservationId;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation updated successfully!");
                            DashboardPage dashboard = new DashboardPage(UserSession.username);
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the reservation.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the reservation: {ex.Message}");
            }
        }


        private void CmbMyReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMyReservations.SelectedValue != null)
            {
                if (cmbMyReservations.SelectedValue is decimal reservationDecimal)
                {
                    int reservationId = Convert.ToInt32(reservationDecimal);
                    LoadReservationDates(reservationId);
                }
                else
                {
                    MessageBox.Show("Invalid reservation ID.");
                }
            }
        }


        private void ManageReservation_Load(object sender, EventArgs e)
        {
            DtpNewStartDate.MinDate = DateTime.Now.Date;
            DtpNewEndDate.MinDate = DateTime.Now.Date;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //redirecting to reservation page
            Reservationpage rp = new Reservationpage(UserSession.username);
            rp.Show();
            this.Hide();
        }
    }
}
