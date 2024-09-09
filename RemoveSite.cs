using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace TouristManagement
{
    public partial class RemoveSite : Form
    {
        public RemoveSite()
        {
            InitializeComponent();
            LoadSites();
        }

        //populating the combo box with data from sites table
        private void LoadSites()
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
                            CmbForAllSites.Items.Clear();
                            while (reader.Read())
                            {
                                CmbForAllSites.Items.Add(reader["SiteName"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading sites: " + ex.Message);
            }
        }

        //code to delete a site selected in combo box
        private void BtnDeleteSite_Click(object sender, EventArgs e)
        {
            string selectedSite = CmbForAllSites.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedSite))
            {
                MessageBox.Show("Please select a site to delete.");
                return;
            }

            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Sites WHERE SiteName = :siteName";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("siteName", selectedSite));
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Site deleted successfully.");
                            LoadSites(); 
                            ViewAllSites viewAllSites = new ViewAllSites();
                            viewAllSites.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No site found with the selected name.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the site: " + ex.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //redirecting to admin page
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }
    }
}
