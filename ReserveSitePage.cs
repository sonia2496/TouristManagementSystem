
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


namespace TouristManagement
{
    public partial class ReserveSitePage : Form
    {
        private string username;
        private SiteAvailabilityNotifier notifier;

        public ReserveSitePage(string username)
        {
            InitializeComponent();
            this.username = username;
            notifier = new SiteAvailabilityNotifier();

            var user = new User(username, LstNotifications);
            notifier.Attach(user);

            LoadSiteData();

            // Setting up the MinDate to current date to prevent past dates from being selected in the date time picker 
            DateTime today = DateTime.Today;

            dtpReservationDate.MinDate = today;
            dtpReservationDate.MaxDate = today;

            dtpStartDate.MinDate = today;
            dtpEndDate.MinDate = today;
        }

        //loading the sites where availability is yes
        private void LoadSiteData()
        {
            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var conn = dbConnection.CreateConnection())
                {
                    conn.Open(); 

                    var query = @"
                    SELECT SiteID, SiteName, Availability, AvailableFrom FROM Sites  
                    WHERE Availability = 'Y'";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var dt = new DataTable();
                            dt.Load(reader);

                            foreach (DataRow row in dt.Rows)
                            {
                                Console.WriteLine($"SiteID: {row["SiteID"]}, SiteName: {row["SiteName"]}, Availability: {row["Availability"]}");
                            }

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No sites found.");
                            }
                            else
                            {
                                cmbChooseSite.DisplayMember = "SiteName";
                                cmbChooseSite.ValueMember = "SiteID";
                                cmbChooseSite.DataSource = dt;
                            }
                        }
                    }

                    // Clearing the notifications list and notifier's future available sites list to prevent duplicates
                    LstNotifications.Items.Clear();
                    notifier.ClearFutureAvailableSites();

                    // Loading future available sites
                    query = @"
                    SELECT SiteName, AvailableFrom FROM Sites  
                    WHERE Availability = 'N' AND AvailableFrom IS NOT NULL";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var siteName = reader["SiteName"].ToString();
                                var availableFrom = Convert.ToDateTime(reader["AvailableFrom"]);
                                var notification = $"{siteName} available from {availableFrom.ToShortDateString()}";

                                // Checking if the notification is already in the list
                                if (!LstNotifications.Items.Contains(notification))
                                {

                                    LstNotifications.Items.Add(notification);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading site data: {ex.Message}");
            }
        }




        private bool AvoidDuplicateReservation(int siteId, DateTime startDate, DateTime endDate, string username)
        {
            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var conn = dbConnection.CreateConnection())
                {
                    conn.Open(); // Ensure the connection is open
                    var query = @"
                SELECT COUNT(*)
                FROM Reservations
                WHERE SiteID = :SiteID
                AND Username = :Username
                AND ((StartDate <= :EndDate AND EndDate >= :StartDate))"; // Check for overlapping dates

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("SiteID", OracleDbType.Int32)).Value = siteId;
                        cmd.Parameters.Add(new OracleParameter("Username", OracleDbType.Varchar2)).Value = username;
                        cmd.Parameters.Add(new OracleParameter("StartDate", OracleDbType.Date)).Value = startDate;
                        cmd.Parameters.Add(new OracleParameter("EndDate", OracleDbType.Date)).Value = endDate;

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Returns true if there is an overlapping reservation
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while checking reservations: {ex.Message}");
                return false;
            }
        }

        private void btnBookReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbChooseSite == null || cmbChooseSite.SelectedValue == null)
                {
                    MessageBox.Show("No site selected.");
                    return;
                }

                string siteIdString = cmbChooseSite.SelectedValue.ToString();
                int siteId;

                if (!int.TryParse(siteIdString, out siteId))
                {
                    MessageBox.Show("Invalid SiteID selected.");
                    return;
                }

                string siteName = cmbChooseSite.Text;

                DateTime reservationDate = dtpReservationDate.Value;
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                if (startDate < DateTime.Today || endDate < DateTime.Today)
                {
                    MessageBox.Show("Reservation dates cannot be in the past.");
                    return;
                }

                if (startDate > endDate)
                {
                    MessageBox.Show("End Date must be greater than or equal to Start Date.");
                    return;
                }

                

                var dbConnection = DatabaseConnection.Instance;
                using (var conn = dbConnection.CreateConnection())
                {
                    conn.Open(); 

                    // Checking if the site is available from a future date
                    var query = @"
                SELECT AvailableFrom
                FROM Sites
                WHERE SiteID = :SiteID";

                    DateTime? availableFrom = null;

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("SiteID", OracleDbType.Int32)).Value = siteId;

                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            availableFrom = Convert.ToDateTime(result);
                        }
                    }

                    if (availableFrom.HasValue && availableFrom.Value > endDate)
                    {
                        MessageBox.Show($"The selected site will be available from {availableFrom.Value.ToShortDateString()}. Please select different dates.");
                        return;
                    }

                    // Query to check for existing overlapping reservations
                    query = @"
                SELECT COUNT(*)
                FROM Reservations
                WHERE SiteID = :SiteID
                AND Username = :Username
                AND (
                    (StartDate <= :EndDate AND EndDate >= :StartDate)
                )";

                    int overlapCount;

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("SiteID", OracleDbType.Int32)).Value = siteId;
                        cmd.Parameters.Add(new OracleParameter("Username", OracleDbType.Varchar2)).Value = this.username;
                        cmd.Parameters.Add(new OracleParameter("StartDate", OracleDbType.Date)).Value = startDate;
                        cmd.Parameters.Add(new OracleParameter("EndDate", OracleDbType.Date)).Value = endDate;

                        overlapCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    if (overlapCount > 0)
                    {
                        MessageBox.Show("You already have a reservation for this site during the selected dates.");
                        return;
                    }

                    // Inserting reservation into reservation table 
                    query = "INSERT INTO Reservations (SiteID, SiteName, ReservationDate, StartDate, EndDate, Username) " +
                            "VALUES (:SiteID, :SiteName, :ReservationDate, :StartDate, :EndDate, :Username)";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("SiteID", OracleDbType.Int32)).Value = siteId;
                        cmd.Parameters.Add(new OracleParameter("SiteName", OracleDbType.Varchar2)).Value = siteName;
                        cmd.Parameters.Add(new OracleParameter("ReservationDate", OracleDbType.Date)).Value = reservationDate;
                        cmd.Parameters.Add(new OracleParameter("StartDate", OracleDbType.Date)).Value = startDate;
                        cmd.Parameters.Add(new OracleParameter("EndDate", OracleDbType.Date)).Value = endDate;
                        cmd.Parameters.Add(new OracleParameter("Username", OracleDbType.Varchar2)).Value = this.username;

                        cmd.ExecuteNonQuery();
                    }

                    DialogResult dialog = MessageBox.Show("Do you want to confirm the booking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        decimal amount = GenerateRandomAmount(5000, 20000);
                        Coupon coupon = null; 
                        IDiscountStrategy discountStrategy = new PercentageDiscountStrategy();

                        // Redirect to PaymentPage form

                        PaymentPage paymentPage = new PaymentPage(amount, coupon, discountStrategy, this.username, siteName);
                        paymentPage.Show(); 
                        this.Hide(); 
                    }
                    else if (dialog == DialogResult.No)
                    {
                        MessageBox.Show("Booking canceled");
                        Reservationpage reservationpage = new Reservationpage(username);
                        reservationpage.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private decimal GenerateRandomAmount(decimal min, decimal max)
        {
            var random = new Random();
            // Generating a random amount for site
            decimal amount = (decimal)(random.NextDouble() * ((double)max - (double)min) + (double)min);
            return amount;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            //redirecting to reservation page
            Reservationpage rp = new Reservationpage(UserSession.username);
            rp.Show();
            this.Hide();
        }
    }
}