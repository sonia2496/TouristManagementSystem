using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace TouristManagement
{
    public partial class UpdateSite : Form
    {
        public UpdateSite()
        {
            InitializeComponent();
            CmbSiteName.SelectedIndexChanged += CmbSiteName_SelectedIndexChanged;
        }

        private void UpdateSite_Load(object sender, EventArgs e)
        {
            // Populating the ComboBox with site names when the form loads
            PopulateSiteNames();
            // Populating the ComboBox with availability options
            PopulateAvailabilityOptions();
        }

        private void CmbSiteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbSiteName.SelectedItem != null)
            {
                string selectedSiteName = CmbSiteName.SelectedItem.ToString();
                FetchSiteDetails(selectedSiteName);
            }
        }
        
        //fetching the site details from sites table
        private void FetchSiteDetails(string siteName)
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT SiteName, Description, Location, Availability, AvailableFrom " +
                                   "FROM Sites WHERE SiteName = :siteName";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("siteName", siteName));

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TxtNewSiteName.Text = reader["SiteName"].ToString();
                                TxtNewDescription.Text = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : string.Empty;
                                TxtNewLocation.Text = reader["Location"] != DBNull.Value ? reader["Location"].ToString() : string.Empty;

                                string availability = reader["Availability"] != DBNull.Value ? reader["Availability"].ToString() : string.Empty;
                                if (CmbAvailability.Items.Contains(availability))
                                {
                                    CmbAvailability.SelectedItem = availability;
                                }
                                else
                                {
                                    CmbAvailability.SelectedIndex = -1; 
                                }

                                if (reader["AvailableFrom"] != DBNull.Value)
                                {
                                    DtpAvailableDate.Value = Convert.ToDateTime(reader["AvailableFrom"]);
                                }
                                else
                                {
                                    DtpAvailableDate.Value = DateTime.Now;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No details found for the selected site.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching site details: " + ex.Message);
            }
        }

        //populating the combo box with sites name from sites table
        private void PopulateSiteNames()
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT SiteName FROM Sites";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            CmbSiteName.Items.Clear();

                            while (reader.Read())
                            {
                                CmbSiteName.Items.Add(reader["SiteName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading site names: " + ex.Message);
            }
        }

        //populating the availability options into combo box
        private void PopulateAvailabilityOptions()
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT DISTINCT Availability FROM Sites";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            CmbAvailability.Items.Clear();

                            while (reader.Read())
                            {
                                string availabilityOption = reader["Availability"].ToString();
                                CmbAvailability.Items.Add(availabilityOption);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading availability options: " + ex.Message);
            }
        }

        private void BtnUpdateSite_Click(object sender, EventArgs e)
        {
            try { 
            
                if (CmbSiteName.SelectedItem == null)
                {
                    MessageBox.Show("Please select a site name.");
                    return;
                }

                // Collecting the  data from the form
                string siteName = TxtNewSiteName.Text.Trim();
                string description = TxtNewDescription.Text.Trim();
                string location = TxtNewLocation.Text.Trim();
                string availability = CmbAvailability.SelectedItem?.ToString();
                DateTime availableFrom = DtpAvailableDate.Value;

                // Validating the input to check if the site name and availability is not empty
                if (string.IsNullOrEmpty(siteName) || string.IsNullOrEmpty(availability))
                {
                    MessageBox.Show("Site Name and Availability are required.");
                    return;
                }

                // updating the database
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = "UPDATE Sites SET Description = :description, Location = :location, " +
                                   "Availability = :availability, AvailableFrom = :availableFrom " +
                                   "WHERE SiteName = :siteName";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description));
                        cmd.Parameters.Add(new OracleParameter("location", string.IsNullOrEmpty(location) ? (object)DBNull.Value : location));
                        cmd.Parameters.Add(new OracleParameter("availability", availability));
                        cmd.Parameters.Add(new OracleParameter("availableFrom", availableFrom));
                        cmd.Parameters.Add(new OracleParameter("siteName", siteName));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Site details updated successfully.");
                            ViewAllSites viewAllSites = new ViewAllSites();
                            viewAllSites.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No site details were updated. Please check if the site name is correct.");
                        }
                    }
                }
            }
            catch (OracleException oraEx)
            {
                MessageBox.Show("An Oracle error occurred while updating site details: " + oraEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating site details: " + ex.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //redirect to admin page
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }
    }
}
