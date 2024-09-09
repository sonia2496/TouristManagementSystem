using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    public interface IPaymentStrategy
    {
        //processes payment in decimal amt.
        void ProcessPayment(decimal amount);
    }
}
