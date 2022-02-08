using System;
class Problem
{
    public static void Main(string[] args)
    {
        int F_Input = int.Parse(Console.ReadLine());


        for(int i = 0; i < F_Input; i++)
        {
            int g_num = 0;
            int num = 0;
            int number = 0;
            int value = 0;

            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[input.Length];
            for (int j = 0; j < input.Length; j++)
            {
                array[j] = Convert.ToInt32(input[j]);
            }
            for (int k = 0; k < array.Length - 2; k++)
            {
                if (array[k] < array[k + 1])
                {
                    g_num = k + 1;
                }
            }
            for (int m = 0; m < array.Length - 1; m++)
            {
                num = array[g_num] - array[m];
                number += num;
            }
            value = array[array.Length - 1] - number;
            if(value<0 || value % 3 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}