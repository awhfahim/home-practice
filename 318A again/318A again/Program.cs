using System;
class A318
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        long Fnum = Convert.ToInt64(input[0]);
        long Snum = Convert.ToInt64(input[1]);
        long j = 0;
        long[] array = new long[Fnum];
        for(int i = 1; i <= Fnum; i++)
        {
            if (i % 2 != 0)
            {
                array[j] = i;
                j++;
            }
        }
        for(int i = 2; i <= Fnum; i++)
        {
            if (i % 2 == 0)
            {
                array[j] = i;
                j++;
            }
        }
        Console.WriteLine(array[Snum-1]);
    }
}
