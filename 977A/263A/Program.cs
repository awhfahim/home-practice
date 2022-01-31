using System;
class A263
{
    public static void Main(string[] args)
    {
        string[] a = new string[5];
        int x = 0;
        for (int i = 0; i < 5; i++)
        {
            a[i] = Console.ReadLine();

        }
        for(int i =0; i<5; i++)
        {
            if (a[i].Contains("1"))
            {
                x = i; 
            }
        }
        
    }
}