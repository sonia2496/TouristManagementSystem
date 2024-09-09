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
    public partial class HomePage : Form
    {
        private int _roleId;
        private string _username;


        public HomePage(int roleId, string username)
        {
            InitializeComponent();
            _roleId = roleId;
            _username = username;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //redirecting to reservation page
            Reservationpage reservationpage = new Reservationpage(_username);
            reservationpage.Show();
            this.Hide();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            //redirecting to update profile page
            UpdateProfile updateProfile = new UpdateProfile(_username);
            updateProfile.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //redirecting to form1 page
            this.Close();
            Form1 form1 = new Form1(); 
            form1.Show();
        }
    }
}
