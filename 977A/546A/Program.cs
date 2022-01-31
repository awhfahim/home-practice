using System;
class A546
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] sep = input.Split(" ");

        int Bananaprice = int.Parse(sep[0]);
        int Money = int.Parse(sep[1]);

        int NumBanana = int.Parse(sep[2]);
        int Total = 0;
        int Total2 = 0;

        for(int i = 1; i <= NumBanana; i++)
        {
            Total = Bananaprice * i;
            
            Total2 += Total;
        }
        Console.WriteLine((Total2 <= Money)? "0": (Total2-Money));

    }
}