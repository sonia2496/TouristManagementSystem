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
    public partial class Reservationpage : Form
    {
        private string username;


        public Reservationpage(string username)
        {
            InitializeComponent();
            this.username = username;
        
        }

        private void btnReserveASite_Click(object sender, EventArgs e)
        {
            //redirect to reservesite page
            ReserveSitePage reservationSitePage = new ReserveSitePage(this.username);
            reservationSitePage.Show();
            this.Hide();
        }
        private void btnCancelreservation_Click(object sender, EventArgs e)
        {
            //redirect to cancel reservation page
            CancelReservation cancelReservation = new CancelReservation(this.username);
            cancelReservation.Show();
            this.Hide();
        }

        private void btnManagereservations_Click(object sender, EventArgs e)
        {
            //redirect to manage reservation page
            ManageReservation manageReservation = new ManageReservation(this.username);
            manageReservation.Show();
            this.Hide();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //redirect to dashboard page
            DashboardPage dashboard = new DashboardPage(UserSession.username);
            dashboard.Show();
            this.Hide();

        }

    }
}
