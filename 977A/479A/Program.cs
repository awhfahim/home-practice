using System;
class A479
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int r1 = (a + b) * c;
        int r2 = (a * b) + c;
        int r3 = a * b * c;
        int r4 = a + b + c;
        int r5 = a * (b + c);
        int r6 = a + (b * c);

        int j = 0;
        int[] array = { r1, r2, r3, r4, r5, r6 };
        for(int i = 0; i<array.Length-1; i++)
        {
            if (array[j] < array[i + 1])
            {
                j = i+1;
            }
        }
        Console.WriteLine(array[j]);
    }
}