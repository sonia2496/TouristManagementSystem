using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    public class ETransferPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            // Processing E-Transfer payments
            MessageBox.Show("Processing E-Transfer Payment....Please wait");
            Task.Delay(1000).Wait();
            MessageBox.Show("Booking successfully done");
            RedirectToDashboard();
        }
        private void RedirectToDashboard()
        {
            //redirect user to reservation page
            string currentUsername = UserSession.username;

            Reservationpage res = new Reservationpage(UserSession.username);
            res.Show();

            Form currentForm = Application.OpenForms["PaymentPage"]; 
            if (currentForm != null)
            {
                currentForm.Close();
            }
        }
    }
}
