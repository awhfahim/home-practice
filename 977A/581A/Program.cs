using System;

class A581
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();
        string[] b = a.Split(' ');
        int x = int.Parse(b[0]);
        int y = int.Parse(b[1]);

        int g = 0;
        int m = 0;
        if (x > y)
        {
            g = x - y;
            m = g / 2;
            Console.WriteLine($"{y} {m}");
        }
        else if (x < y)
        {
            g = y - x;
            m = g / 2;
            Console.WriteLine($"{x} {m}");
        }
        else
        {
            Console.WriteLine($"{x} 0");
        }
    }
}


