using System;
class A1431
{
    public static void Main(string[] args)
    {
        int S_Input = Convert.ToInt32(Console.ReadLine());
        string[] Customers = Console.ReadLine().Split(' ');
        int[] array = new int[S_Input];
        for(int i = 0; i < S_Input; i++)
        {
            array[i] = Convert.ToInt32(Customers[i]);

        }
        for(int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}