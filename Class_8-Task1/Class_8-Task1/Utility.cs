using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_Task1
{
    internal class Utility
    {
        internal void Reverse(string input)
        {
            string f;
            char[] db = input.ToCharArray();
            for(int i = input.Length-1; i>-1; i--)
            {
                Console.Write(db[i]);
            }
        }
    }
}
