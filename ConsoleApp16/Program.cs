using System;
namespace findmxnum
{
    public static class fdmaxnum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value of Two Numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            //Condition to find Maximum Number
            switch (num1 > num2)
            {
                case true:
                    Console.WriteLine("num1 is the maximum Number");
                    break;
                    case false:
                    Console.WriteLine("num 2 is the maximum number");
                    break;
            }
        }
    }
}
