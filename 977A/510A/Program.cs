using System;
class A510
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int row = int.Parse(input[0]);
        int Colm = int.Parse(input[1]);


        for (int i = 1; i<=row; i++)
        {
            if (i % 2 != 0)
            {
                for(int j=0; j<Colm; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            else if (i % 4 == 0)
            {
                Console.Write("#");
                for (int j = 0; j < Colm - 1; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            else if (i % 2 == 0)
            {
                for (int j = 0; j < Colm-1; j++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                Console.WriteLine();
            }
                
        }

    }
}
