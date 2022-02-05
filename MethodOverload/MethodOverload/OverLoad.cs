using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class OverLoad
    {
        internal string ?name { get; set; }
        internal OverLoad()
        {
            name = " Md Rashedul Islam";
        }
        public string Mymethod()
        {
            name = "Md A.W.H Fahim";
            return name;
        }
        public string Mymethod(string name)
        {
            name = "Md Rayhanul Islam Raj";
            return name;
        }
        public int Mymethod(int num)
        {
            num = 23565225;
            return num;
        }
        
    }
}
