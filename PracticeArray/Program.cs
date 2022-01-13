using System;
namespace arrayexmp1
{
    public static class array1
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Elements are {0} ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}  ", array[i]);
            }
        }
    }
}
