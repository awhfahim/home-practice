using System;
namespace ifelseprac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num - 10 == 2)
            {
                Console.WriteLine("The Statement is true");
            }
            else
            {
                Console.WriteLine("The Statement is false");
            }
        }

    }
}