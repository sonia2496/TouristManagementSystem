using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    public class PaymentRecord
    {
        public int PaymentID { get; set; }
        public string Username { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; } 

        public PaymentRecord(int paymentID, string username, decimal amount, DateTime paymentDate, string status)
        {
            PaymentID = paymentID;
            Username = username;
            Amount = amount;
            PaymentDate = paymentDate;
            Status = status;
        }
    }
}
