﻿using System;
class Numrev
{
    public static void Main(string[] args)
    {
        string numbers = (Console.ReadLine());
        int number = int.Parse(numbers);
        int s = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int denominator = number % 10;
            int dividend = number / 10;
            if (dividend < 10)
            {
                dividend = dividend * 10;
                s = s + dividend;
            }
            break;

            number = dividend;

            s = (s * 10) + denominator;
        }
        Console.WriteLine(s);
    }
}

