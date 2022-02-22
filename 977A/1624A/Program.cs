using System;
class A1624
{
   public static void Main(string[] args)
    {
        int Test = int.Parse(Console.ReadLine());
        for (int i = 0; i < Test; i++)
        {
            int a = int.Parse(Console.ReadLine());
            string[] element = Console.ReadLine().Split(' ');
            int[] array = new int[a];
            for(int j = 0; j<a; j++)
            {
                array[j] = int.Parse(element[j]);
            }
            for (int j = 0; j < a; j++)
            {
                for(int m = 0; m<a-1; m++)
                {
                    if (array[m] > array[m + 1])
                    {
                        int temp = array[m];
                        array[m] = array[m + 1];
                        array[m + 1] = temp;
                    }
                }
            }
            Console.WriteLine(array[array.Length-1]-array[0]);
        }
    }
}