using System;
class Contest
{
    public static void conquer(int[] array, int si, int mid, int ei)
    {
        int[] merged = new int[ei - si + 1];

        int idx1 = si;
        int idx2 = mid + 1;
        int x = 0;

        while (idx1 <= mid && idx2 <= ei)
        {
            if (array[idx1] <= array[idx2])
            {
                merged[x++] = array[idx1++];
            }
            else
            {
                merged[x++] = array[idx2++];
            }
        }

        while (idx1 <= mid)
        {
            merged[x] = array[idx1];
            idx1++; x++;
        }

        while (idx2 <= ei)
        {
            merged[x++] = array[idx2++];
        }

        for (int i = 0, j = si; i < merged.Length; i++, j++)
        {

            array[j] = merged[i];

        }
    }
    public static void divide(int[] array, int si, int ei)
    {
        if (si >= ei)
        {
            return;
        }
        int mid = si + (ei - si) / 2;
        divide(array, si, mid);
        divide(array, mid + 1, ei);
        conquer(array, si, mid, ei);
    }
    public static void Main(string[] args)
    {
        int Input = int.Parse(Console.ReadLine());
        for(int i = 0; i< Input; i++)
        {
            string[] S_input = Console.ReadLine().Split(' ');
            int n = int.Parse(S_input[0]);
            int x = int.Parse(S_input[1]);
            int count = 0;

            string[] T_input = Console.ReadLine().Split(' ');
            int[] array = new int[n];
            for(int j = 0; j < n; j++)
            {
                array[j] = int.Parse(T_input[j]);
            }

            divide(array, 0, n - 1);

            for (int j = 0; j < n; j++)
            {
                if (array[j] > 0)
                {
                    int r = x * array[j];
                    for (int q = 0; q < n; q++)
                    {
                        if (r == array[q] && j != q)
                        {
                            array[q] = 0;
                            array[j] = 0;

                            count++;
                            break;
                        }
                    }
                }
            }
            int res = count * 2;
            Console.WriteLine(n-res);
        }
    }
}