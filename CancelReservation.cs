using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace TouristManagement
{
    public partial class CancelReservation : Form
    {
        private string username;

        public CancelReservation(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadReservations();
        }

        private void LoadReservations()
        {
            //populate the combo box with reservations
            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var con = dbConnection.CreateConnection())
                {
                    con.Open(); // Opening the connection

                    var cmd = new OracleCommand("SELECT ReservationID, SiteName FROM Reservations WHERE UserName = :username", con);
                    cmd.Parameters.Add(new OracleParameter("username", username));

                    var adapter = new OracleDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        cmbCancelReservation.DisplayMember = "SiteName";
                        cmbCancelReservation.ValueMember = "ReservationID";
                        cmbCancelReservation.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No reservations found for this user.");
                    }

                    con.Close(); // Closing the connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading reservations: " + ex.Message);
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (cmbCancelReservation == null)
            {
                MessageBox.Show("ComboBox is not initialized.");
                return;
            }

            if (cmbCancelReservation.SelectedItem == null)
            {
                MessageBox.Show("Please select a reservation to cancel.");
                return;
            }

            string siteIdString = cmbCancelReservation.SelectedValue.ToString();
            if (!int.TryParse(siteIdString, out int reservationID))
            {
                MessageBox.Show("Invalid reservationID selected.");
                return;
            }

            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var con = dbConnection.CreateConnection())
                {
                    con.Open(); // Opening the connection

                    // Deleting the selected reservation from the database
                    var cmd = new OracleCommand("DELETE FROM Reservations WHERE ReservationID = :reservationId AND UserName = :username", con);
                    cmd.Parameters.Add(new OracleParameter("reservationId", reservationID));
                    cmd.Parameters.Add(new OracleParameter("username", username));

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation cancelled successfully and refund will be processed in 3-4 working days.");
                        // Refresh the dropdown
                        LoadReservations();

                        //redirect the user to reservation page
                        Reservationpage reservationpage = new Reservationpage(UserSession.username);
                        reservationpage.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Error cancelling reservation.");
                    }

                    con.Close(); // Closing the connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while cancelling the reservation: " + ex.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //on click of back, go back to reservation page
            Reservationpage rp = new Reservationpage(UserSession.username);
            rp.Show();
            this.Hide();
        }
    }
}