using System;

class A110
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();
    
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == '7')
            {
                count++;
            }
            else if (a[i] == '4')
            {
                count++;
            }
        }
        if(count == 4 || count == 7)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}


