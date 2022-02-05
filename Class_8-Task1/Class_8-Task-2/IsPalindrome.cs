using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_8_Task_2
{
    internal class IsPalindrome
    {
        internal bool Palindrome(string input)
        {
            string a = string.Empty;
            char[] chars = input.ToCharArray();
            for(int i = input.Length-1; i>-1; i--)
            {
                a += chars[i];
            }
            return input == a;
        }
    }
}
