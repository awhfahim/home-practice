using System;
namespace arraysubstraction
{
    public static class arraysubstarct
    {
        public static void Main(string[] args)
        {
            int[,] array1 = new int[3, 3];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    
                    Console.Write($"Elements - [{i}],[{j}] : ");
                    
                    array1[i, j] = int.Parse(Console.ReadLine());    
                }
            }
            Console.WriteLine("Input 2nd array");
            int[,] array2 = new int[3, 3];
            for( int i = 0;i < 3; i++)
            {
                for( int j = 0;j < 3; j++)
                {
                    Console.Write($"Elements - [{i}],[{j}] : ");
                    array2[i, j] = int.Parse(Console.ReadLine());
                    int rar = array2[i, j];
                }
            }
            Console.WriteLine("The First Matrix is : ");
            for (int i = 0; i < 3; i++)
            {
                
                for (int j = 0; i < 3; j++)
                { 
                Console.Write("{0}\t", i, j);

                }     

            }

        }
    }
}
