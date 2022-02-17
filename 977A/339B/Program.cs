using System;

class B339
{
    public static void Main(string[] args)
    {
        string[] F_Input = Console.ReadLine().Split(' ');

        long n = int.Parse(F_Input[0]);
        long m = int.Parse(F_Input[1]);

        string[] S_Input = Console.ReadLine().Split(' ');
        long[] array = new long[m];
        for (long i = 0; i < m; i++)
        {
            array[i] = Convert.ToInt64(S_Input[i]);
        }

        long y = 0;
        long x = 0;
        long sum = 0;

        for (long i = 0; i < m - 1; i++)
        {
            y = array[0] - 1;
            if (array[i] > array[i + 1])
            {
                long subs = n - array[i];
                x = array[i + 1]-0;
                sum += subs + x;
            }
            else
            {
                x = (array[i+1] - array[i]);
                sum += x;
            }
        }
        Console.WriteLine(sum + y);

    }
}

