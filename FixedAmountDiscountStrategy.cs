using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    public class FixedAmountDiscountStrategy : IDiscountStrategy
    {
        //Applying discount coupans
        public decimal ApplyDiscount(decimal amount, Coupon coupon)
        {
            if (coupon.IsValid)
            {
                return amount - coupon.DiscountPercentage; 
            }
            return amount;
        }
    }
}
