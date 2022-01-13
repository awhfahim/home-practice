using System;
namespace reversenum
{
    public static class reversenum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the value of array");
            int n =int.Parse(Console.ReadLine());
            int[] bn = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Numbers {0} : ", i);
                bn[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Printing numbers in the reverse order");
            for(int i = n-1; i>=0; i--)
            {
                
                Console.Write(bn[i]+" ");
                
            }
            Console.WriteLine();
        }
    }
}
