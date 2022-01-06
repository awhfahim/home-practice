using System;

namespace IdentifyGrade
{
    public static class Grades
    {
        public static void Main(string[] args)

        {
            int num = Convert.ToInt32(Console.ReadLine());
            if(num<0 && num>100)
            {
                Console.WriteLine("Your Grade is Invalid");
            }
            else if(num>=0 && num <= 50)
            {
                Console.WriteLine("Failed, Try Next Time");
            }
            else if(num>=50 && num <= 60)
            {
                Console.WriteLine("Your Grade Is 'D'");
            }
            else if(num>=61 && num<= 70)
            {
                Console.WriteLine("Your Grade Is 'c'");
            }
            else if(num>=71 && num <= 80)
            {
                Console.WriteLine("Your Grade Is 'B'");
            }
            else if(num>=81 && num <= 90)
            {
                Console.WriteLine("Your Grade Is 'A");
            }
            else if(num>=90 && num <= 100)
            {
                Console.WriteLine("You are Rock");
            }



        }
    }
}