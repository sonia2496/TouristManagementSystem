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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            //redirect to form1 page
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void BtnViewAllSites_Click(object sender, EventArgs e)
        {
            //redirect to view site page
            ViewAllSites viewAllSites = new ViewAllSites();
            viewAllSites.Show();
            this.Hide();
        }

        private void BtnAddSite_Click(object sender, EventArgs e)
        {
            //redirect to add site page
            AddSite addSite = new AddSite();
            addSite.Show();
            this.Hide();
        }

        private void BtnRemoveSite_Click(object sender, EventArgs e)
        {
            //redirect to remove site page
            RemoveSite removeSite = new RemoveSite();
            removeSite.Show();
            this.Hide();
        }

        private void BtnUpdateSite_Click(object sender, EventArgs e)
        {
            //redirect to update site page
            UpdateSite updateSite = new UpdateSite();
            updateSite.Show();
            this.Hide();
        }

        private void BtnViewAllUsers_Click(object sender, EventArgs e)
        {
            //redirect to view all users page
            ViewAllUsers viewAllUsers = new ViewAllUsers();
            viewAllUsers.Show();
            this.Hide();
        }

        private void BtnRemoveUser_Click(object sender, EventArgs e)
        {
            //redirect to remove user page
            RemoveUser removeUser = new RemoveUser();
            removeUser.Show();
            this.Hide();
        }

        private void BtnViewAllReservations_Click(object sender, EventArgs e)
        {
            //redirect to view all reservations page
            ViewAllReservations viewAllReservations = new ViewAllReservations();
            viewAllReservations.Show();
            this.Hide();
        }

       
    }
}
