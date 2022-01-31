using System;

class A236
{
    public static void Main(string[] args)
    {
        string Word = Console.ReadLine();

        string New = string.Empty;

        for (int i = 0; i < Word.Length; i++)
        {
            if (!New.Contains(Word[i]))
            {
                New += Word[i];
            }
        }
        Console.WriteLine((New.Length % 2 == 0)? "CHAT WITH HER!" : "IGNORE HIM!");
    }
}
