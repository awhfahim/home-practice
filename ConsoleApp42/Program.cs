using System;
public class watermelon
{
    public static void Main(string[] args)
    {
        float w = int.Parse(Console.ReadLine());
        float y = w % 2;
        if (w == 2)
        {
            Console.WriteLine("NO");
        }
        else if (y / 2 == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

