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
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //redirect to admin oage
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }

        //populating the combo box from users table
        private void LoadUsers()
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT UserID, UserName FROM Users WHERE RoleID = 2";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            CmbUserName.Items.Clear(); 

                            while (reader.Read())
                            {
                                
                                CmbUserName.Items.Add(new
                                {
                                    UserID = reader["UserID"],
                                    UserName = reader["UserName"].ToString()
                                });
                            }
                        }
                    }

                    CmbUserName.DisplayMember = "UserName";
                    CmbUserName.ValueMember = "UserID";

                    if (CmbUserName.Items.Count > 0)
                    {
                        CmbUserName.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading users: " + ex.Message);
            }
        }

        //setting up button to remove the user from the users table
        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            if (CmbUserName.SelectedItem != null)
            {
                // Retrieving the selected user's ID
                var selectedUser = (dynamic)CmbUserName.SelectedItem;
                string userName = selectedUser.UserName;

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteUser(userName);

                  
                }
            }
            else
            {
                MessageBox.Show("Please select a user to remove.");
            }
        }

        //setting up button to delete selected user from users table
        private void DeleteUser(string userName)
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE UserName = :UserName";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("userName", userName));
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User removed successfully.");
                            LoadUsers();
                            AdminPage adminPage = new AdminPage();
                            adminPage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error removing user. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing the user: " + ex.Message);
            }
        }

    }
}
