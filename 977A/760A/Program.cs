using System;
class A760
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int Month_Num = Convert.ToInt32(input[0]);
        int Date_Num = Convert.ToInt32(input[1]);

        int number = 0;
        int date = 0;
        if (Month_Num == 1 || Month_Num == 3 || Month_Num == 5 || Month_Num == 7 || Month_Num == 8
            || Month_Num == 10 || Month_Num == 12)
            number = 31;
        else if (Month_Num == 6 || Month_Num == 4 || Month_Num == 9 || Month_Num == 11)
            number = 30;
        else
            number = 28;

        date = Date_Num - 1;

        int total = number + date;

        int Coloumn = total / 7;

        int Max = Coloumn * 7;
        if(total-Max>0)
            Console.WriteLine(Coloumn+1);
        else
            Console.WriteLine(Coloumn);
        
    }
}