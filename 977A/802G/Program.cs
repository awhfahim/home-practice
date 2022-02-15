using System;
class G802
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] Alphabets = { "h", "e", "i", "d", "i" };
        int index = 0;
        string word = string.Empty;
        bool condition = true;
        int i = 0;

        while (condition)
        {
            if (!input.Contains(Alphabets[i]))
                condition = false;
            else if (i == 4)
                condition = false;
            if (input.Contains(Alphabets[i]))
            {
                index = input.IndexOf(Alphabets[i]);
                word = input.Substring(index + 1);
                input = word;
                i++;
            }
        }
        Console.WriteLine((i == 5) ? "YES" : "NO");
    }
}