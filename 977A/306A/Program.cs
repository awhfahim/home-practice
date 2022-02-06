using System;
class A306
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int candies = int.Parse(input[0]);
        int friends = int.Parse(input[1]);
        int b = 0;
        int d = 0;
        int c = 0;
        int e = 0;

        if (candies % friends == 0)
        {
            for (int i = 0; i < friends; i++)
            {
                string number = Convert.ToString(candies / friends);
                Console.Write($"{number} ");
            }

        }
        else if (candies % friends != 0)
        {
            for (int i = 1; i < candies; i++)
            {
                if (friends * i < candies)
                {
                    b = i;
                    d = b * friends;
                    c = candies - d;
                    e = friends - c;
                }
            }
            for (int i = 0; i < e; i++)
            {
                Console.Write($"{b} ");
            }
            for (int i = 0; i < c; i++)
            {
                Console.Write($"{b + 1} ");
            }
        }
    }
}
