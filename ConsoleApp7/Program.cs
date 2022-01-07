using System;
namespace maxbetwn3num
{
    public static class maxbetwn3num
    {
        public static void Main(string[] args)
        {
            int a = 6;
            int b = 9;
            int c = 8;
            if(a>b && a>c)
            {
                Console.WriteLine("A is gretater than b and c");
            }
            else if(b>c && b>a)
            {
                Console.WriteLine("B is greater than a and c");
            }
            else
            {
                Console.WriteLine("C is greater than a and b");
            }
        }
    }
}