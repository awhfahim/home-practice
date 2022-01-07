using System;
namespace nummbercheck
{
    public static class numbercheck
    {
        public static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("The Number is negative");
            }
            else if(num > 0)
            {

                Console.WriteLine("The Number is Positive");
            }
            else
            {
                Console.WriteLine("The Number is O");
            }
        }
    }
}
