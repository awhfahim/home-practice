using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Teacher
    {
        internal int age { get; set; }
        internal string ?Name { get; set; }

        internal string ?Address { get; set; }

        internal string ?id { get; set; }

        internal void GenerateNewId()
        {
           id =  "T-" + DateTime.Now.Ticks;
        }
    }

}


