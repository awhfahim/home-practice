using System;
class A617
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        if (a % 5 == 0)
        {
            Console.WriteLine(a / 5);

        }
        int b = a % 5;
        int c = a / 5;
        for (int i = 1; i <= b; i++)
        {
            if (i % b == 0)
            {
                Console.WriteLine(c + 1);
            }
        }
    }
}



