using System;
namespace tltnummonth
{
    public static class tltnummonth
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a month between Jan to Dec");
            string month = Console.ReadLine();
            switch (month)
            {
                case "january":
                    Console.WriteLine("There are 31 days in Januray");
                    break;
                case "February":
                    Console.WriteLine("There are 28 days in this month except Leap year");
                    break;
                case "March":
                    Console.WriteLine("There are 31 days in March");
                    break;
                case "april":
                    Console.WriteLine("There are 30 days in April");
                    break;
                case "May":
                    Console.WriteLine("There are 31 days in this Month");
                    break;
                case "June":
                    Console.WriteLine("There are 30 days in this Month");
                    break;
                case "July":
                    Console.WriteLine("There are 31 days in this month");
                    break;
                case "August":
                    Console.WriteLine("There are 30 days in this month");
                    break;
                case "september":
                    Console.WriteLine("There are 31 days in this month");
                    break;
                case "October":
                    Console.WriteLine("There are 30 days in this month");
                    break;
                case "November":
                    Console.WriteLine("There are 31 days in this month");
                    break;
                case "December":
                    Console.WriteLine("There are 30 days in this month");
                    break;
                    default:
                    Console.WriteLine("Please enter the month name in alphabet");
                    break;
            }

        }
    }
}