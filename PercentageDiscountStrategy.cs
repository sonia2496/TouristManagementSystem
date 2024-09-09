using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount, Coupon coupon)
        {
            //Calculating the discount percentage and applying discount
            if (coupon.IsValid)
            {
                return amount - (amount * coupon.DiscountPercentage / 100);
            }
            return amount;
        }
    }
}
