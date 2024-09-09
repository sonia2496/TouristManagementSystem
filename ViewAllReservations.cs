using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace TouristManagement
{
    public partial class ViewAllReservations : Form
    {
        public ViewAllReservations()
        {
            InitializeComponent();
            InitializeListView();
            LoadReservations();
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Initializing the list view columns
            listView1.Columns.Add("ReservationID", 100);
            listView1.Columns.Add("SiteID", 100);
            listView1.Columns.Add("ReservationDate", 150);
            listView1.Columns.Add("StartDate", 150);
            listView1.Columns.Add("EndDate", 150);
            listView1.Columns.Add("SiteName", 150);
            listView1.Columns.Add("UserName", 150);
        }

        //fetching the reservation data
        private void LoadReservations()
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT * FROM Reservations";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            listView1.Items.Clear();
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["ReservationID"].ToString());
                                item.SubItems.Add(reader["SiteID"].ToString());
                                item.SubItems.Add(reader["ReservationDate"].ToString());
                                item.SubItems.Add(reader["StartDate"].ToString());
                                item.SubItems.Add(reader["EndDate"].ToString());
                                item.SubItems.Add(reader["SiteName"].ToString());
                                item.SubItems.Add(reader["UserName"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading reservations: " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
