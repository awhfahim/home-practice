using System;

class B999
{
    public static void Main(string[] args)
    {
        int Input = int.Parse(Console.ReadLine());
        string S_string = Console.ReadLine();

        char[] array = new char[S_string.Length];
        int g = 0;

        for(int i = 2; i<=Input; i++)
        {
            if (Input % i == 0)
            {
                for(int j = i-1; j>-1; j--)
                {
                    Console.Write(S_string[j]);
                }
                break;
            }
        }
    }
}