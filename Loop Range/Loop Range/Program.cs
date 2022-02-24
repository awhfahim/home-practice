using System;

public class B230
{
    public static void Main(string[] args)
    {
        long n = Convert.ToInt64(Console.ReadLine());
        long i = 0;
        long count = 0;
        string[] nums = Console.ReadLine().Split(' ');
        long[] num = new long[n];

        foreach (string s in nums)
            num[i++] = Convert.ToInt64(s);

        for (i = 0; i < 1; i++)
        {
            long j = 1;
            count = 0;
            while (count < 4 && j <= num[i])
            {
                if (num[i] % j == 0)
                    count++;
                j++;
            }

            if (count == 3)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}