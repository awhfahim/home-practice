using System;
namespace menudriven
{
    public static class menudriven
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Here is the menudriven List ");
            Console.Write("\n\n-----------------------------\n\n");
            Console.WriteLine("Input the value of a nnd b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("\nClick 1 to perform Addition");
            Console.WriteLine("Click 2 to perform Substraction");
            Console.WriteLine("Click 3 to perform Multiplication");
            Console.WriteLine("Click 4 to perform Division");

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine(a+b);
                    break;
                case 2:
                    Console.WriteLine(a-b);
                    break;
                case 3:
                    Console.WriteLine(a*b);
                    break;
                case 4:
                    Console.WriteLine(a/b);
                    break;
            }
        }
    }
}
