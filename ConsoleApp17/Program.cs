using System;
namespace forLoop
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int i,sum=0;
            Console.WriteLine("Enter the Value of n");
            int n=int.Parse(Console.ReadLine());
            for (i = 1; i<=n; i+=2)
            {
               
               sum +=i;

            }
            {

                Console.WriteLine(sum);


            }

        }
    }
}
