using System;
class B158
{
    public static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int four = 0;
        int three = 0;
        int two = 0;
        int one = 0;
        int sum = 0;
        int tsum = 0;
        int osum = 0;

        string[] groups = Console.ReadLine().Split(' ');
        int[] array = new int[groups.Length];
        for(int i = 0; i<groups.Length; i++)
        {
            array[i] = int.Parse(groups[i]);
            if (array[i] == 4)
            {
                four++;
            }
            else if(array[i] == 3)
            {
                three++;
            }
            else if (array[i] == 2)
            {
                two++;
            }
            else
            {
                one++;
            }
        }
        if (three > one)
        {
                int tr = three - one;//3-2
                sum = tr + one;
            one = 0;
        }
        else if(three == one)
        {
            sum = three;
            one = 0;
        }
        else if (three < one) // 3-1
        {
            one = one - three;
            sum = three;
        }
        if (two > 0)
        {
            if (two > one || two < one || two == one)
            {
                tsum = two * 2;
                int total = tsum + one;
                one = 0;
                if (total < 4)
                {
                    tsum = 1;
                }
                else if (total % 4 != 0)
                {
                    int res = total / 4;
                    tsum = res + 1;
                }
                else
                {
                    tsum = total / 4;
                }
            }
        }
        if (one > 0)
        {
            if (one < 4)
            {
                osum = 1;
            }
            else if (one % 4 == 0)
            {
                osum = one / 4;
            }
            else if (one % 4 != 0)
            {
                int q = one / 4;
                osum = q + 1;
            }
        }
        Console.WriteLine(four+sum+tsum+osum);
    }
}
