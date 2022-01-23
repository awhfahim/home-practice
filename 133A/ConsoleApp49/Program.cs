using System;

class a133
{
    public static void Main(string[] args)
    {
        string p = Console.ReadLine();
        string a = "H";
        string b = "Q";
        string c = "9";
        //string d = "+";
        if (p.Contains(a) || p.Contains(b) || p.Contains(c))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}



