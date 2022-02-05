using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncProgram
{
    internal class FirstMethod
    {
        internal int Fahim(string name, int count)
        {
            for(int i = 0; i<name.Length; i++)
            if(name.Contains("a"))
            {
                count++;
            }
            return count;
        }
    }
}
