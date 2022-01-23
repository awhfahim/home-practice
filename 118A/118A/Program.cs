using System;

public class gfg8A
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string str1 = str.ToLower();
        string str2 = str1.Replace("a", "");
        string str3 = str2.Replace("i", "");
        string str4 = str3.Replace("e", "");
        string str5 = str4.Replace("o", "");
        string str6 = str5.Replace("u", "");
        string str7 = str6.Replace("y", "");

        char[] ch = str7.ToCharArray();


        foreach (char c in ch)
        {
            Console.Write("." + c);
        }

    }
}










