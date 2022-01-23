using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("else"));
            Console.WriteLine(test("else"));
            Console.ReadLine();
        }

        public static string test(string s)
        {
            if (s.Length > 2 && s.Substring(0, 2).Equals("if"))
            {
                return s;
            }
            return "if " + s;
        }
    }
}


