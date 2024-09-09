using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            //Processign Paypal payment of user
            MessageBox.Show("Processing Paypal Payment....Please wait");
            Task.Delay(1000).Wait();
            MessageBox.Show("Booking successfully done");
            RedirectToDashboard();
        }
        private void RedirectToDashboard()
        {
            //redirecting user to the reservation page
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
