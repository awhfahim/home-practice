using System;
class Bubble_Sort
{
    public static void Main(string[] args)
    {
        //string input = Console.ReadLine();
        int[] num = { 64, 34, 25, 12, 22, 11, 90 };
        //int count = 0;
        //foreach(char s in input)
        //{
        //    num[count] = Convert.ToInt32(s.ToString());
        //    count++;
        //}
        for(int j = 0; j < num.Length; j++)
        {
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] > num[i + 1])
                {
                    num[i] = num[i] + num[i + 1];
                    num[i + 1] = num[i] - num[i + 1];
                    num[i] = num[i] - num[i + 1];
                }
            }
        }
        foreach(int n in num)
        {
            Console.Write($"{n},");
        }
    }
}