using System;
class A448
{
    public static void Main(string[] args)
    {
        string[] F_input = Console.ReadLine().Split(' ');
        string[] S_input = Console.ReadLine().Split(' ');
        int L_input = int.Parse(Console.ReadLine());

        int F_Sum = int.Parse(F_input[0]) + int.Parse(F_input[1]) + int.Parse(F_input[2]);
        int S_Sum = int.Parse(S_input[0]) + int.Parse(S_input[1]) + int.Parse(S_input[2]);

        int i = 0;
        int j = 0;

        for(int m = 0; m < 1;)
        {
            if (F_Sum + S_Sum == 0)
            {
                Console.WriteLine("YES");
                break;
            }
            if (F_Sum == 0)
                i = 0;
            else if (F_Sum > 5 && F_Sum % 5 != 0)
                i = (F_Sum / 5) + 1;
            else if (F_Sum > 5 || F_Sum == 5)
                i = F_Sum / 5;
            else if (F_Sum < 5)
                i = 1;

            if (S_Sum == 0)
                j = 0;
            else if (S_Sum > 10 && S_Sum % 10 != 0)
                j = (S_Sum / 10) + 1;
            else if (S_Sum > 10 || S_Sum == 10)
                j = S_Sum / 10;
            else if (S_Sum < 10)
                j = 1;

            int total = i + j;

            if (total <= L_input)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            break;
        }
        
    }
}