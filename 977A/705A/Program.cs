using System;
 class A705z
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        string m = "I hate that I love that ";
        string k = "I hate it";
        int n = 0;

        if (a == 1)
        {
            Console.WriteLine("I hate it");
        }
        else if (a % 2 == 1)
        {
            n = a / 2;
            for(int i = 0; i<n; i++)
            {
                Console.Write(m);
            }
            Console.Write(k);
        }
        else if (a % 2 == 0)
        {
            n = a / 2;
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(m);

            }
            Console.Write("I hate that I love it");
        }

    }
}

