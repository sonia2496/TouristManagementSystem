using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace TouristManagement
{
    public partial class ViewAllSites : Form
    {
        public ViewAllSites()
        {
            InitializeComponent();

            // Initializing the ListView control
            InitializeListView();
        }

        private void InitializeListView()
        {
            LstViewAllSites.View = View.Details;

            // Adding the columns to the ListView
            LstViewAllSites.Columns.Add("Site ID", 100);
            LstViewAllSites.Columns.Add("Site Name", 150);
            LstViewAllSites.Columns.Add("Description", 250);
            LstViewAllSites.Columns.Add("Location", 150);
            LstViewAllSites.Columns.Add("Availability", 100);
            LstViewAllSites.Columns.Add("Available From", 120);
        }

        private void ViewAllSites_Load(object sender, EventArgs e)
        {
            PopulateListView();
        }

        //populating the listview with data from sites table
        private void PopulateListView()
        {
            try
            {
                LstViewAllSites.Items.Clear();

                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT SiteID, SiteName, Description, Location, Availability, AvailableFrom FROM Sites ORDER BY SiteID DESC";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["SiteID"].ToString());

                                item.SubItems.Add(reader["SiteName"] != DBNull.Value ? reader["SiteName"].ToString() : string.Empty);
                                item.SubItems.Add(reader["Description"] != DBNull.Value ? reader["Description"].ToString() : string.Empty);
                                item.SubItems.Add(reader["Location"] != DBNull.Value ? reader["Location"].ToString() : string.Empty);
                                item.SubItems.Add(reader["Availability"] != DBNull.Value ? reader["Availability"].ToString() : string.Empty);

                                if (reader["AvailableFrom"] != DBNull.Value)
                                {
                                    item.SubItems.Add(Convert.ToDateTime(reader["AvailableFrom"]).ToString("yyyy-MM-dd"));
                                }
                                else
                                {
                                    item.SubItems.Add(string.Empty);
                                }

                                LstViewAllSites.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BtnlogOut_Click(object sender, EventArgs e)
        {
            //redirecting to form1 page on click of logout button
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //redirect to admin page on click of Home button
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }

        private void LstViewAllSites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
