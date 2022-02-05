using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public class MyClass
    {
        internal string Names()
        {
            string x = "Values";
            return x;

        }

        internal int Practice(string name)
        {
            int count = 0;
            for(int i = 0; i<name.Length; i++)
            {
                if(name[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        internal int Arrays()
        {
            int[] numbers = new int[5];
            int sum = 0;
            for(int i = 0; i<numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            return sum;
        }

        internal int Cube(int a, int b)
        {
            int rvalue=1;
            for(int i = 1; i<=b; i++)
            {
                rvalue = rvalue * a;
            }
            return rvalue;
        }
        
    }

}
