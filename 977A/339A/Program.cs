using System;
class A339
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] number = input.Split('+');

        int[] numbers = new int[number.Length];
        for(int i = 0; i<number.Length; i++)
        {
            numbers[i] = int.Parse(number[i]);
        }
        for (int i = 0; i < numbers.Length-1; i++)
        {
            Array.Sort(numbers);
            Console.Write($"{numbers[i]}+");
            
            
        }
        Console.Write(numbers[numbers.Length - 1]);
    }
}
