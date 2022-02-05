using System;

class A935
{
    public static void Main(string[] args)
    {
        int count = 0; 
        int num = int.Parse(Console.ReadLine());

        for(int i = 1; i<num; i++)
        {
            if (num % i == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
