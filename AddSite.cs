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
    public partial class AddSite : Form
    {
        public AddSite()
        {
            InitializeComponent();
        }

        private void BtnAddSite_Click(object sender, EventArgs e)
        {
            //button to add a new site 
            string siteName = TxtSiteName.Text;
            string description = TxtSiteDesc.Text;
            string location = TxtSiteLoc.Text;
            string availability = cmbAvailability.SelectedItem?.ToString();
            DateTime availableFrom = DtpAvailFrom.Value;

            LblError.Text = ""; 

            if (string.IsNullOrWhiteSpace(siteName) || string.IsNullOrWhiteSpace(availability))
            {
                LblError.Text = "Site Name and Availability are required.";
                return;
            }

            if (availability != "Y" && availability != "N")
            {
                LblError.Text = "Invalid availability selected."; 
                return;
            }

            try
            {
                using (var conn = DatabaseConnection.Instance.CreateConnection())
                {
                    //inserting data into sites table
                    conn.Open();
                    string query = "INSERT INTO Sites (SiteName, Description, Location, Availability, AvailableFrom) " +
                                   "VALUES (:siteName, :description, :location, :availability, :availableFrom)";
                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("siteName", OracleDbType.Varchar2)).Value = siteName;
                        cmd.Parameters.Add(new OracleParameter("description", OracleDbType.Varchar2)).Value = description;
                        cmd.Parameters.Add(new OracleParameter("location", OracleDbType.Varchar2)).Value = location;
                        cmd.Parameters.Add(new OracleParameter("availability", OracleDbType.Char)).Value = availability;
                        cmd.Parameters.Add(new OracleParameter("availableFrom", OracleDbType.Date)).Value = availableFrom;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Site added successfully!");

                            this.Close();
                            //redirecting the user to admin page once site is added successfully.
                            AdminPage adminPage = new AdminPage();
                            adminPage.Show();
                            this.Hide();

                        }
                        else
                        {
                            //populate the label error
                            LblError.Text = "Failed to add site. Please try again.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LblError.Text = "An error occurred: " + ex.Message;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //redirecting the user to admin page
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            this.Hide();
        }
    }
}