using System;
class Contest
{
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
            Array.Sort(array);
            //for(int j = 0; j<n; j++)
            //{
            //    for(int m = 0; m<n-1; m++)
            //    {
            //        if (array[m] > array[m + 1])
            //        {
            //            int temp = array[m];
            //            array[m] = array[m + 1];
            //            array[m + 1] = temp;
            //        }
            //    }
            //}

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