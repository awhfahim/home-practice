using System;
class A318
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int Fnum = int.Parse(input[0]);
        int Lnum = int.Parse(input[1]);
        int j = 0;
        if (Fnum % 2 != 0)
        {
            int[] array = new int[Math.Abs(Fnum / 2) + 1];
            for (int i = 1; i <= Fnum; i++)
            {
                if (i % 2 != 0)
                {
                    array[j] = i;
                    j++;
                }
            }
            int x = 0;
            int[] array1 = new int[Math.Abs(Fnum / 2)];
            for (int i = 2; i <= Fnum; i++)
            {
                if (i % 2 == 0)
                {
                    array1[x] = i;
                    x++;
                }
            }
            int n = 0;
            int[] array2 = new int[Fnum];
            for (int i = 0; i < Math.Abs(Fnum / 2) + 1; i++)
            {
                array2[n] = array[i];
                n++;
            }
            for (int i = 0; i < Math.Abs(Fnum / 2); i++)
            {
                array2[n] = array1[i];
                n++;

            }
            Console.WriteLine(array2[Lnum - 1]);
        }
        else
        {
            int[] array = new int[Fnum / 2];
            for (int i = 1; i <= Fnum; i++)
            {
                if (i % 2 != 0)
                {
                    array[j] = i;
                    j++;
                }
            }
            int x = 0;
            int[] array1 = new int[Fnum / 2];
            for (int i = 2; i <= Fnum; i++)
            {
                if (i % 2 == 0)
                {
                    array1[x] = i;
                    x++;
                }
            }
            int n = 0;
            int[] array2 = new int[Fnum];
            for (int i = 0; i < Fnum / 2; i++)
            {
                array2[n] = array[i];
                n++;
            }
            for (int i = 0; i < Fnum / 2; i++)
            {
                array2[n] = array1[i];
                n++;

            }
            Console.WriteLine(array2[Lnum - 1]);
        }

    }
}
