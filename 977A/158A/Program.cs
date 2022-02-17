using System;

class A158
{
    public static void Main(string[] args)
    {
        string[] F_Input = Console.ReadLine().Split(' ');
        int a = int.Parse(F_Input[0]);
        int b = int.Parse(F_Input[1]);
        int count = 0;
        int sum = 0;

        string[] S_Input = Console.ReadLine().Split(' ');
        int[] array = new int[a];
        for(int i = 0; i<a; i++)
        {
            array[i] = int.Parse(S_Input[i]);
        }
        for(int i = 0; i < a-1; i++)
        {
            int m = array[i] + array[i + 1];
             sum +=  m;
        }
        if (array.Length == 1)
        {
            if (array[0] > 0)
            {
                count = 1;
            }
        }
        else if (sum == 0)
        {
            count = 0;
        }
        else if(array[b-1] == 0)
        {
            for (int j = 0; j < a; j++)
                if (array[b-1] < array[j])
                    count++;
        }
        else if (array[b-1] > 0)
        {
            for (int j = 0; j < a; j++)
            {
                if (array[b - 1] == array[j] || array[b - 1] < array[j])
                {
                    count++;
                }
            }
        }
       
        Console.WriteLine(count);
    }
}