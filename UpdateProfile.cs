using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using BCrypt.Net;

namespace TouristManagement
{
    public partial class UpdateProfile : Form
    {
        private string _username;

        public UpdateProfile(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void btnUpdateUserName_Click(object sender, EventArgs e)
        {
            //Fetching the values from text boxes
            string currentUserName = txtCurrentUserName.Text.Trim();
            string newUserName = txtNewUserName.Text.Trim();

            if (string.IsNullOrEmpty(currentUserName) || string.IsNullOrEmpty(newUserName))
            {
                MessageBox.Show("Both current and new usernames are required.");
                return;
            }

            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var con = dbConnection.CreateConnection())
                {
                    con.Open();

                    // Verifying the current username
                    var cmd = new OracleCommand("SELECT COUNT(*) FROM Users WHERE UserName = :currentUserName", con);
                    cmd.Parameters.Add(new OracleParameter("currentUserName", currentUserName));
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount == 0)
                    {
                        MessageBox.Show("Current username not found.");
                        return;
                    }

                    // Updating the new username in the database
                    var updateCmd = new OracleCommand("UPDATE Users SET UserName = :newUserName WHERE UserName = :currentUserName", con);
                    updateCmd.Parameters.Add(new OracleParameter("newUserName", newUserName));
                    updateCmd.Parameters.Add(new OracleParameter("currentUserName", currentUserName));
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Username updated successfully, please login again.");
                        txtCurrentUserName.Clear();
                        txtNewUserName.Clear();

                        // Redirecting to Form1
                        this.Close();
                        Form1 form1 = new Form1(); 
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error updating username.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            //fetching the values from text boxes
            string currentPassword = txtCurrentPwd.Text.Trim();
            string newPassword = txtNewPwd.Text.Trim();
            string retypePassword = txtReTypeNewPwd.Text.Trim();

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(retypePassword))
            {
                MessageBox.Show("All password fields are required.");
                return;
            }

            if (newPassword != retypePassword)
            {
                MessageBox.Show("New password and re-typed password do not match.");
                return;
            }

            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var con = dbConnection.CreateConnection())
                {
                    con.Open();

                    // Fetching the current hashed password from the database
                    var cmd = new OracleCommand("SELECT PasswordHash FROM Users WHERE UserName = :username", con);
                    cmd.Parameters.Add(new OracleParameter("username", _username));
                    string storedPasswordHash = Convert.ToString(cmd.ExecuteScalar());

                    if (storedPasswordHash == null)
                    {
                        MessageBox.Show("User not found.");
                        return;
                    }

                    // Verifying the current password
                    if (!BCrypt.Net.BCrypt.Verify(currentPassword, storedPasswordHash))
                    {
                        MessageBox.Show("Current password is incorrect.");
                        return;
                    }

                    // Hashing the new password
                    string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                    // Updating the new password in the database
                    var updateCmd = new OracleCommand("UPDATE Users SET PasswordHash = :hashedNewPassword WHERE UserName = :username", con);
                    updateCmd.Parameters.Add(new OracleParameter("hashedNewPassword", hashedNewPassword));
                    updateCmd.Parameters.Add(new OracleParameter("username", _username));
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully, please login again.");
                        txtCurrentPwd.Clear();
                        txtNewPwd.Clear();
                        txtReTypeNewPwd.Clear();

                        // Redirecting to Form1
                        this.Close();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error updating password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
