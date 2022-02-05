using System;

class A1
{
    public static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');
        decimal L = int.Parse(numbers[0]);
        decimal W = int.Parse(numbers[1]);
        decimal Square = int.Parse(numbers[2]);

        Console.WriteLine(Math.Ceiling(L / Square) * Math.Ceiling(W / Square));
    }
}
