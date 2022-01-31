using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Teacher
    {
        internal int Age { get; set; }
        public string Name
        {
            get { return val; }
            set
            {
                if (Name.StartsWith("Md"))
                    Name = value;
            }
        }
        
        internal string Address { get; set; }
    }
}
