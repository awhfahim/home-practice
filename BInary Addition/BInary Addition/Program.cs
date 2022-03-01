using System;

namespace BinaryAdd
{
    public class AdditionBinary
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Input 1st Binary Number : ");
            string Binary_1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please Input 2nd Binary Number : ");
            string Binary_2 = Console.ReadLine();

            if (Binary_1.Length > Binary_2.Length)
            {
                int lnth = Binary_1.Length - Binary_2.Length;
                string s = "0";
                for(int x = 0; x<lnth; x++)
                {
                    Binary_2 = s + Binary_2;
                }
            }
            else if(Binary_1.Length < Binary_2.Length)
            {
                int lnth = Binary_2.Length - Binary_1.Length;
                string s = "0";
                for (int y = 0; y < lnth; y++)
                {
                    Binary_1 = s + Binary_1;
                }
            }
            int n = Binary_1.Length;
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            int i = 0; int j = 0;

            foreach (char c in Binary_1)
            {
                arr1[j] = Convert.ToString(c); j++;
            }
            foreach (char c in Binary_2)
            {
                arr2[i] = Convert.ToString(c); i++;
            }

            int carry = 0;
            string[] arr3 = new string[n];
            for(int m = n-1; m>-1; m--)
            {
                int add = int.Parse(arr1[m]) + int.Parse(arr2[m]) + carry;
                if (add == 0)
                {
                    arr3[m] = "0";
                    carry = 0;
                }
                else if (add == 1)
                {
                    arr3[m] = "1";
                    carry = 0;
                }
                else if (add == 2)
                {
                    arr3[m] = "0";
                    carry = 1;
                }
                else if (add == 3)
                {
                    arr3[m] = "1";
                    carry = 1;
                }
            }

            if (carry > 0)
            {
                Console.Write(carry);
            }
            foreach(string a in arr3)
            {
                Console.Write(a);
            }
        } 
    }
}