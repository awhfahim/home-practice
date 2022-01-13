using System;
namespace array2
{
    public static class array2
    {
        public static void Main(string[] args)
        {
       
            Console.WriteLine("Please enter the value of: n");
            int n = int.Parse(Console.ReadLine());
            int[] vla = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("variable value: {0}", i);
                vla[i] =int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Value of the Variables are: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write( "{0} ",vla[i]) ;
            }
            
        }
    }
}
