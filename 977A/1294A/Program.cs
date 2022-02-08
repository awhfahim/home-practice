using System;

class A1294
{
    public static void Main(string[] args)
    {
        int FstNum = Convert.ToInt32(Console.ReadLine());
        string[] Numbers = new string[FstNum];
        for(int i = 0; i < FstNum; i++)
        {
            Numbers[i] = Console.ReadLine();
            string[] spliter = Numbers[i].Split();
            int a = int.Parse(spliter[0]);
            int b = int.Parse(spliter[1]);
            int c = int.Parse(spliter[2]);
            int d = int.Parse(spliter[3]);
            if (a == b && b == c)
            {
                if(d%3==0)
                    Console.WriteLine("YES");
                else if(d==0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            else if (a>b && a>c)
            {
                int x = a - b;
                int y = a - c;
                int n = x + y;
                int f = d - n;
                if(f==0)
                    Console.WriteLine("YES");
                else if (n > d)
                    Console.WriteLine("NO");
                else if (f%3==0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("NO");
            }
            if (b > a && b > c)
            {
                int x = b - a;
                int y = b - c;
                int n = x + y;
                int f = d - n;
                if (f == 0)
                    Console.WriteLine("YES");
                else if (n > d)
                    Console.WriteLine("NO");    
                else if (f % 3 == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("NO");
            }
            if (c > b && c > a)
            {
                int x = c - b;
                int y = c - a;
                int n = x + y;
                int f = d - n;
                if (f == 0)
                    Console.WriteLine("YES");
                else if (n>d)
                    Console.WriteLine("NO");
                else if (f % 3 == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}