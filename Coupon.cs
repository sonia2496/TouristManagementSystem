using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    public class Coupon
    {
        public string Code { get; set; }
        public decimal DiscountPercentage { get; set; }
        public bool IsValid { get; set; }

        public Coupon(string code, decimal discountPercentage, bool isValid)
        {
            Code = code;
            DiscountPercentage = discountPercentage;
            IsValid = isValid;
        }
    }

}
