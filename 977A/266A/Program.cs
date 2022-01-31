using System;
class A266
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] == a[i + 1])
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}