using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Teacher
    {
        private string name;
        public string? Name
        {
            get { return name; }
            internal set
            {
                if (value.EndsWith("m"))
                {
                    name = value;
                }
            }
        }

        internal bool PrimeNum(int num)
        {
            for(int i = 2; i<num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
