using System;
class Recursive
{
    internal static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n*Factorial(n-1);
    }
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(Factorial(num));
    }
}