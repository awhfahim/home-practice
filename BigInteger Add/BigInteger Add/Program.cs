using System;
class Big_integer
{
    public static string BigSum(string a,string b)
    {
        int a_idx1 = Convert.ToInt32(a[0]);
        int b_idx1 = Convert.ToInt32(b[0]);
        if (a.Length < b.Length)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        else if (a.Length == b.Length && b_idx1 > a_idx1)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        int plus = 0;
        int x = a.Length - b.Length;
        string[] charC = new string[x + b.Length];
        for (int q = 0; q < x + b.Length; q++)
        {
            if (q < x)
            {
                charC[q] = "0";
            }
            else
            {
                charC[q] = Convert.ToString(b[plus]);
                plus++;
            }
        }

        int i = 0;
        int j = 0;

        string[] charA = new string[a.Length];
        foreach (char c in a)
        {
            charA[i] = Convert.ToString(c);
            i++;
        }

        int[] up = new int[a.Length];
        for (int l = 0; l < a.Length; l++)
        {
            up[l] = int.Parse(charA[l]);
        }

        int[] down = new int[charC.Length];
        for (int l = 0; l < charC.Length; l++)
        {
            down[l] = int.Parse(charC[l]);
        }

        string[] arr = new string[charA.Length];
        for (int m = a.Length - 1; m > -1; m--)
        {
            if (up[m] < down[m])
            {
                up[m] = up[m] + 10;
                arr[m] = Convert.ToString(up[m] - down[m]);
                down[m - 1] = down[m - 1] + 1;
            }
            else
            {
                arr[m] = Convert.ToString(up[m] - down[m]);
            }
        }
        string t = string.Empty;
        foreach (string c in arr)
            t = t + c;
        return t;
    }
    public static void Main(string[] args)
    {
        string a = Console.ReadLine();
        Console.WriteLine("(-)");
        string b = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Answer is - ");
        Console.WriteLine(BigSum(a,b));
    }
}