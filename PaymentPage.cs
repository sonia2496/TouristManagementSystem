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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TouristManagement
{
    public partial class PaymentPage : Form
    {
        private IPaymentStrategy _paymentStrategy;
        private IDiscountStrategy _discountStrategy;
        private decimal _amount; 
        private Coupon _coupon;
        private string _username;
        private string _siteName;


        public PaymentPage(decimal amount, Coupon coupon, IDiscountStrategy discountStrategy, string username, string siteName)
        {
            InitializeComponent();
            _amount = amount;
            _coupon = coupon;
            _discountStrategy = discountStrategy;
            _username = username; 
            _siteName = siteName; 

        }
        private decimal ApplyDiscount()
        {
            if (_discountStrategy != null && _coupon != null)
            {
                return _discountStrategy.ApplyDiscount(_amount, _coupon);
            }
            return _amount;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        //logging the payment into payment history table
       private void LogPayment(string status)
{
            try
            {
                var dbConnection = DatabaseConnection.Instance;
                using (var conn = dbConnection.CreateConnection())
                {
                    conn.Open(); //opening the connection

                    var query = @"
                        INSERT INTO PaymentHistory (Username, SiteName, Amount, PaymentDate, Status) 
                        VALUES (:Username, :SiteName, :Amount, :PaymentDate, :Status)";

                    using (var cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("Username", OracleDbType.Varchar2)).Value = _username;
                        cmd.Parameters.Add(new OracleParameter("SiteName", OracleDbType.Varchar2)).Value = _siteName;
                        cmd.Parameters.Add(new OracleParameter("Amount", OracleDbType.Decimal)).Value = _amount;
                        cmd.Parameters.Add(new OracleParameter("PaymentDate", OracleDbType.Date)).Value = DateTime.Now;
                        cmd.Parameters.Add(new OracleParameter("Status", OracleDbType.Varchar2)).Value = status;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while logging payment: {ex.Message}");
            }
}

        //disabling the payment methods once an option is selected
        private void DisablePaymentButtons()
        {
            BtnCreditCard.Enabled = false;
            BtnETransfer.Enabled = false;
            BtnPayPal.Enabled = false;
        }

        private void BtnCreditCard_Click(object sender, EventArgs e)
        {
            SetPaymentStrategy(new CreditCardPayment());
            var finalAmount = ApplyDiscount();
            _paymentStrategy.ProcessPayment(finalAmount); 
            LogPayment("Completed"); 
            DisablePaymentButtons();
        }

        private void BtnETransfer_Click(object sender, EventArgs e)
        {
            SetPaymentStrategy(new ETransferPayment());
            var finalAmount = ApplyDiscount();
            _paymentStrategy.ProcessPayment(finalAmount); 
            LogPayment("Completed"); 
            DisablePaymentButtons(); 
        }

        private void BtnPayPal_Click(object sender, EventArgs e)
        {
            SetPaymentStrategy(new PayPalPayment());
            var finalAmount = ApplyDiscount();
            _paymentStrategy.ProcessPayment(finalAmount); 
            LogPayment("Completed"); 
            DisablePaymentButtons(); 
        }
    }
}