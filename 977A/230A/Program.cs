using System;
class A230
{
    public static void Main(string[] args)
    {
        string[] F_input = Console.ReadLine().Split(' ');
        int s = int.Parse(F_input[0]);
        int n = int.Parse(F_input[1]);
        int count = 0;

        string[] array = new string[n];
        for(int i = 0; i<n; i++)
        {
            array[i] = Console.ReadLine();
        }

        int[] strength = new int[n];
        for (int i = 0; i < n; i++)
        {
            strength[i] = int.Parse(array[i].Split(' ')[0]);
        }

        int[] bonus = new int[n];
        for (int i = 0; i < n; i++)
        {
            bonus[i] = int.Parse(array[i].Split(' ')[1]);
        }
        
        for(int i = 0; i<n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if(strength[j] > strength[j + 1])
                {
                    int temp = strength[j];
                    strength[j] = strength[j+1];
                    strength[j+1] = temp;

                    int sd = bonus[j];
                    bonus[j] = bonus[j + 1];
                    bonus[j + 1] = sd;
                }     
            }
        }
        
        for(int i = 0; i<n; i++)
        {
            if (s > strength[i])
            {
                s = s + bonus[i];
                count++;
            }
        }
        Console.WriteLine((count == n)?"YES":"NO");
    }
}
