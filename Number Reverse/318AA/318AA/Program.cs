using System;
class A318
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        long a = Convert.ToInt64(input[0]);
        long b = Convert.ToInt64(input[1]);
        long c = 0;
        if (a % 2 == 0)
        {
            c = a / 2;
        }
        else if(a % 2 != 0)
        {
            c = (a + 1) / 2;
        }

        if (c > b)
        {
            
        }
        else
        {
            
        }
    }
}