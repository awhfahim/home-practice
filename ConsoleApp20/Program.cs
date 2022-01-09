using System;
namespace way2
{
    public static class way2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("size of row");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("size of column");
            int y = int.Parse(Console.ReadLine());
            int[,] rwclmn = new int[x, y];
            {
                for(int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                        rwclmn[i, j] =int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The sum of Row is");
            for(int i = 0; i < x; i++)
            {
                int sum = 0;
                for (int j = 0; j < y; j++)
                {
                    sum += rwclmn[i, j];
                }
                Console.WriteLine(sum);

                    
            }
        }
    }
}
