using Oracle.ManagedDataAccess.Client;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TouristManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //fetching values from text box
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            //fetching value from combo box
            string selectedRole = cboxRole.SelectedItem?.ToString();

            lblLoginError.Text = ""; 
            
            //condition to check if any of the field is empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(selectedRole))
            {
                lblLoginError.Text = "Username, password, and role cannot be empty.";
                return;
            }

            if (selectedRole.Trim().ToLower() == "admin")
            {
                lblLoginError.Text = "Registration as Admin is not allowed.";
                return;
            }

            //validation check for password
            if (!IsValidPassword(password))
            {
                lblLoginError.Text = "Password must be at least \n - 8 characters long, \n - contain at least one uppercase letter, \n - one digit, and \n - one special character.";
                return;
            }

            //validation to check if user already exists or not
            if (UserExists(username))
            {
                lblLoginError.Text = "Username already exists. Please choose a different username.";
                return;
            }

            int roleId = GetRoleId(selectedRole);
            if (roleId == -1)
            {
                lblLoginError.Text = "Invalid role selected.";
                return;
            }

            //used to store the encrypt format of password in database
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open(); //opening the connection
                    //inserting values into users table
                    string query = "INSERT INTO Users (UserName, PasswordHash, RoleID) VALUES (:username, :passwordHash, :roleId)";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;
                        cmd.Parameters.Add(new OracleParameter("passwordHash", OracleDbType.Varchar2)).Value = hashedPassword;
                        cmd.Parameters.Add(new OracleParameter("roleId", OracleDbType.Decimal)).Value = roleId;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            lblLoginError.Text = ""; // Clearing error message label on successful registration
                            MessageBox.Show("Registration successful!");

                            //redirecting the user to login page after registeration to login again
                            LoginPage loginPage = new LoginPage();
                            loginPage.Show();
                            this.Hide();
                        }
                        else
                        {
                            lblLoginError.Text = "Registration failed. Please try again.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblLoginError.Text = "An error occurred: " + ex.Message;
            }
        }

        private bool IsValidPassword(string password)
        {
            // regular expression to check if password is at least 8 characters long
            // and contains at least one uppercase letter,
            // one digit,
            // and one special character
            var regex = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;""'<>,.?/\\|`~-]).{8,}$");
            return regex.IsMatch(password);
        }


        private bool UserExists(string username)
        {
            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    conn.Open();
                    //query to check if user already exists in database
                    string query = "SELECT COUNT(*) FROM Users WHERE UserName = :username";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                lblLoginError.Text = "An error occurred: " + ex.Message;
                return false;
            }
        }

        private int GetRoleId(string roleName)
        {
            switch (roleName.Trim().ToLower())
            {
                //assign role 1 if selected role is admin
                case "admin":
                    return 1;
                    //assign role 2 if selected role is tourist
                case "tourist":
                    return 2;
                default:
                    return -1;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //fetching values from textboxes
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            //fetching values from combobox
            string selectedRole = cboxRole.SelectedItem?.ToString();

            lblLoginError.Text = "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(selectedRole))
            {
                lblLoginError.Text = "Username, password, and role cannot be empty.";
                return;
            }

            int expectedRoleId = GetRoleId(selectedRole);
            if (expectedRoleId == -1)
            {
                lblLoginError.Text = "Invalid role selected.";
                return;
            }

            int roleId;
            bool loginSuccessful = SignIn(username, password, expectedRoleId, out roleId);
            if (loginSuccessful)
            {
                // Setting the username in the UserSession class
                UserSession.username = username;

                // Redirecting to next page based on the selected role
                if (selectedRole.Trim().ToLower() == "admin")
                {
                    AdminPage adminPage = new AdminPage();
                    adminPage.Show();
                }
                else if (selectedRole.Trim().ToLower() == "tourist")
                {
                    HomePage homePage = new HomePage(roleId, username);
                    homePage.Show();
                }
                this.Hide();
            }
            else
            {
                lblLoginError.Text = "Invalid username, password, or role ID.";
            }
        }
        //sign in logic to fetch password and role id corresponsing to username
        private bool SignIn(string username, string password, int expectedRoleId, out int roleId)
        {
            roleId = -1;
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
                                return BCrypt.Net.BCrypt.Verify(password, storedHashedPassword) && roleId == expectedRoleId;
                            }
                            else
                            {
                                return false;
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