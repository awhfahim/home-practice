using System;
class A58
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] alphabets = { "h", "e", "l", "l", "o" };

        bool cond = true;
        int i = 0;

        while (cond)
        {
            
            if (!input.Contains(alphabets[i]))
                cond = false;
            else if (i == 4)
                cond = false;
            if (input.Contains(alphabets[i]))
            {
                int a = input.IndexOf(alphabets[i]);
                input = input.Substring(a + 1);
                i++;
            }
        }
        Console.WriteLine((i == 5) ? "YES" : "NO");
    }
}
