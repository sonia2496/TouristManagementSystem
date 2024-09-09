namespace TouristManagement
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            //Process Credit card payment
            MessageBox.Show("Processing Credit Card Payment....Please wait");
            Task.Delay(1000).Wait();
            MessageBox.Show("Booking successfully done");
            RedirectToDashboard();
        }

        private void RedirectToDashboard()
        {
            //Redirect user to reservation page
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