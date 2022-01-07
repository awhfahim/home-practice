using System;
namespace numberdivisible
{
    public static class NumberDivisibleExtensions
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%5==0)
            {
                Console.WriteLine("The Number is Divisible by 5");
            }
            else if (num%11 == 0)
            {
                Console.WriteLine("This Number Is Divisible by 11");
            }
            else
            {
                Console.WriteLine("This Number is not divisible by 5 and 11");
            }
        }
    }
}