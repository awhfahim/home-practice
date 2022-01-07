using System;
namespace switchexmp
{
    public static class switchstatement
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Day");
            string day = Console.ReadLine();
            switch (day)
            {
                case "SUNDAY":
                    Console.WriteLine("Have a nice Day");
                    break;
                case "friday":
                    Console.WriteLine("Have a bad day");
                    break;
                case "Monday":
                    Console.WriteLine("Have a good day");
                    break;
                default:
                    Console.WriteLine("its not your day");
                    break;
            }
        }
    }
}