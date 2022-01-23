using System;
public static class prob2
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int count = 0;
        string c = string.Empty;
        string[] b = new string[a];
        for(int i = 0; i < a; i++)
        {
            b[i] = Console.ReadLine();
            c = b[i];
            if (b[i].Length > 10)
            {
                
                int last = c.Length - 1;
                count = c.Length - 2;
                Console.WriteLine(c[0] + Convert.ToString(count) + c[last]);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    } 
}