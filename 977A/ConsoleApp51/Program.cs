using System;
class A977
{
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();

        string[] str = a.Split(" ");

        string d = (str[0]);
        int b = Convert.ToInt32(str[1]);
        int k = 0;

        if (b == 0)
        {
            Console.WriteLine(d);
        }


        for (int i = b; b > 0; b--)
        {

            if (d[d.Length - 1] != '0')
            {
                k = int.Parse(d) - 1;
                d = k.ToString();
            }
            else if (d[d.Length - 1] == '0')
            {
                k = int.Parse(d) / 10;
                d = k.ToString();
            }

        }
        Console.WriteLine(k);

    }
}





