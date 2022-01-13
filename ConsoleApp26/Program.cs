using System;
namespace decimalcount
{
    public static class decimalcount
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter three integar number");
            int a =int.Parse (Console.ReadLine());
            int b =int.Parse (Console.ReadLine());
            
            double sum = 0;
            sum = (float)a/b;
          
            Console.WriteLine(sum);
        }
        
    }
}
