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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fetching data from text box
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string selectedRole = cboxRole.SelectedItem?.ToString(); //fetching data from combo box

            lblLoginError.Text = ""; 

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(selectedRole))
            {
                lblLoginError.Text = "Username, password, and role cannot be empty.";
                return;
            }

            int expectedRoleId = GetRoleId(selectedRole); // Get role ID based on the selected role
            if (expectedRoleId == -1)
            {
                lblLoginError.Text = "Invalid role selected.";
                return;
            }

            int roleId;
            bool loginSuccessful = SignIn(username, password, expectedRoleId, out roleId);
            if (loginSuccessful)
            {
                MessageBox.Show("Login successful!");

               //redirecting to home page once login is successful
                HomePage homePage = new HomePage(roleId, username); 
                homePage.Show();
                this.Hide(); 
            }
            else
            {
                lblLoginError.Text = "Invalid username, password, or role ID.";
            }
        }

        private int GetRoleId(string roleName)
        {
            switch (roleName.Trim().ToLower())
            {
                //assigning role ID as 1 if selected role is admin
                case "admin":
                    return 1;
                    //assigning role ID as 2 if selected role is tourist
                case "tourist":
                    return 2;
                default:
                    return -1; 
            }
        }
        //sign-in logic to fetch password and role id corresponding to logged in user
        private bool SignIn(string username, string password, int expectedRoleId, out int roleId)
        {
            roleId = -1; // 
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    string query = "SELECT PasswordHash, RoleID FROM Users WHERE UserName = :username";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader["PasswordHash"].ToString();
                                roleId = Convert.ToInt32(reader["RoleID"]);
                                // Verify password and check role ID
                                return BCrypt.Net.BCrypt.Verify(password, storedHashedPassword) && roleId == expectedRoleId;
                            }
                            else
                            {
                                return false; // Username not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblLoginError.Text = "An error occurred: " + ex.Message;
                return false;
            }
        }
    }
}