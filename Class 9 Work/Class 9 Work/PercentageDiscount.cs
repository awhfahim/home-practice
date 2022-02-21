using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_9_Work
{
    public class PercentageDiscount : Discount
    {
        private double _amount;
        public override double Amount
        {
            get
            {
                if (_amount < 0)
                    return 0;
                else
                {
                    return _amount;
                }
            }
            set
            {
                if (value >= 0)
                    _amount = value;
            }
        }
        public PercentageDiscount(double amount)
            : base(amount)
        {
            Amount = amount; 
        }
        public override double PriceAfterDiscount(double originalPrice)
        {
            return originalPrice - (originalPrice * Amount / 100);
        }
    }
}
