using System;
class A379
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int NN = int.Parse(input[0]);
        int N_Candle = int.Parse(input[0]);   
        int W_Candle = int.Parse(input[1]);   
        bool Condition = true;
        int Result = 0;

        while (Condition)
        {
            int a = N_Candle / W_Candle;  
            int e = N_Candle % W_Candle;  
            int sum = a + e;
            if (sum < W_Candle)
                Condition = false;

            Result += a;
            N_Candle = sum;
        }
        Console.WriteLine(Result+NN);
    }
}
