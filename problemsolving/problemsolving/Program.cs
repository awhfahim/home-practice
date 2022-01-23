using System;

public class program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string str1 = "0000000";
        string str2 = "1111111";
        if (str.Contains(str1))
        {
            Console.WriteLine("YES");
        }
        else if (str.Contains(str2))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}