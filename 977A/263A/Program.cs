using System;
class A263
{
    public static void Main(string[] args)
    {
        string[] a = new string[5];
        int x = 0;
        int y = 0;
        for (int i = 0; i < 5; i++)
        {
            a[i] = Console.ReadLine();

        }
        for(int i =0; i<5; i++)
        {
            if (a[i].Contains("1"))
            {
                x = i;
                break;
            }
        }
        string[] b = a[x].Split(' ');
        for(int i = 0; i< 5; i++)
        {
            if(b[i] == "1")
            {
                y = i;
                break;
            }

        }
        Console.WriteLine(Math.Abs(x-2)+Math.Abs(y-2));
    }
}