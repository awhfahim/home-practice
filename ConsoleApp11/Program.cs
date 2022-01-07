using System;
namespace alphabetcheck
{
    public static class alphabetcheck
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char ch =Convert.ToChar(Console.ReadLine());
            if((ch>='a' && ch<='z') || (ch >='A' && ch <='Z'))
            {
                Console.WriteLine("this is alphabet");
            }
            else
            {
                Console.WriteLine("this is not alphabet");
            }
        }
    }
}