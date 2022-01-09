using System;
namespace task1
{
    public static class task1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Value of X and Y");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] vs = new int[x, y];
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                   vs[i, j] =int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("sum row wise");
            for(int i = 0; i < x; i++)
            {
                int sum = 0;
                for(int j = 0; j<3; j++)
                {
                    sum = sum + vs[i, j];
                }
                Console.WriteLine(sum);
            }
            Console.WriteLine("sum coloumn wise");
            for(int i =0; i < x; i++)
            {
                int sum = 0;
                for( int j = 0; j < y; j++)
                {
                    sum = sum + vs[j,i];
                }
                Console.WriteLine(sum);
            }

        }      

    }
}
