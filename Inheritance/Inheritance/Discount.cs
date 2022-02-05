using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Discount
    {
        public int OriginalAmount { get; set; }
        public double GetDiscount(int Amount)
        {
            OriginalAmount = 2000;
            return OriginalAmount - Amount;
        }
    }
}
