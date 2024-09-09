using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace TouristManagement
{
    public partial class ViewAllUsers : Form
    {
        public ViewAllUsers()
        {
            InitializeComponent();
            InitializeListView();
            LoadUsers();
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Adding the columns to list view
            listView1.Columns.Add("UserID", 100);
            listView1.Columns.Add("Username", 150);
            listView1.Columns.Add("Role", 150);
        }

        //performing a join operation to fetch users data from the database
        private void LoadUsers()
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = @"SELECT u.UserID, u.UserName, r.RoleName 
                                     FROM Users u 
                                     JOIN Roles r ON u.RoleID = r.RoleID
                                     WHERE u.RoleID = 2";


                    using (var cmd = new OracleCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            listView1.Items.Clear();
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["UserID"].ToString());
                                item.SubItems.Add(reader["UserName"].ToString());
                                item.SubItems.Add(reader["RoleName"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading users: " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            {
                //redirecting to admin page on the click of back button
                AdminPage adminPage = new AdminPage();
                adminPage.Show();
                this.Close();
            }


        }
    }
}
