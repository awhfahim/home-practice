using System;
class A41
{
    public static void Main(string[] args)
    {
        string c = Console.ReadLine();
        string a = Console.ReadLine();

        char[] vs = c.ToCharArray();

        string b = String.Empty;
        for (int i = c.Length - 1; i >= 0; i--)
        {
            b += vs[i];
        }
        //Console.WriteLine(b);

        if (b == a)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

