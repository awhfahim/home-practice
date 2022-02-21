  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9_Work
{
    public class Discount
    {
        public virtual double Amount { get; set; }

        public Discount(double amount)
        {
            Amount = amount;
        }
        public virtual double PriceAfterDiscount(double originalPrice)
        {
            return originalPrice - Amount;
        }
    }
}
