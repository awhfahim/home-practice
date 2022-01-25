using System;
 class A705z
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());

        string m = "I hate";
        string b = "that";
        string c = "I love";
        string d = "it";
        if(a > 2)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write($"{m} {b} {c} {b} ", d);

            }
        }
    }
}



/* if(a == 1)
        {
    Console.WriteLine("I hate it");
}
        else if (a == 2)
{
    Console.WriteLine("I hate that I love it");
}
else if (a == 3)
{
    Console.WriteLine("I hate that I love that I hate it");
}
else if (a == 4)
{
    Console.WriteLine("I hate that I love that I hate that I love it");
}
*/