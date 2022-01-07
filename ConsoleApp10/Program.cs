using System;
namespace leapyear
{
    public static class leapyear
    {
     public static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine("It's a Leap Year");
            }
            else if(year%4==0 && year%100 != 0)
            {
                Console.WriteLine("its a leap year");
            }
            else
            {
                Console.WriteLine("its not a Leap year");
            }
        }    
    }
}
