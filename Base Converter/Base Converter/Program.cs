using System;

public class BaseConverter
{
    static int val(char c)
    {
        if (c >= '0' && c <= '9')
            return (int)c - '0';
        else
            return (int)c - 'A' + 10;
    }
    static int toDeci(string str, int basse)
    {
        int len = str.Length;

        int power = 1;

        int num = 0;

        for (int i = len - 1; i >= 0; i--)
        {
            if (val(str[i]) >= basse)
            {
                Console.Write("Invalid Number");
                return -1;
            }

            num += val(str[i]) * power;

            power = power * basse;
        }
        return num;
    }
    static char reVal(int num)
    {
        if (num >= 0 && num <= 9)
            return (char)(num + '0');
        else
            return (char)(num - 10 + 'A');
    }
    static string fromDeci(int basse, int inputNum)
    {
        string res = "";
        while (inputNum > 0)
        {
            res += reVal(inputNum % basse);

            inputNum /= basse;
        }
        res = reverse(res);

        return res;
    }
    static void convertbasse(string s, int a, int b)
    {
        int num = toDeci(s, a);

        string ans = fromDeci(b, num);

        Console.Write(ans);
    }

    static string reverse(string input)
    {
        char[] a = input.ToCharArray();
        int l, r = a.Length - 1;
        for (l = 0; l < r; l++, r--)
        {
            char temp = a[l];
            a[l] = a[r];
            a[r] = temp;
        }
        return new string(a);
    }
    static public void Main()
    {
        string s = "110110";
        int a = 2, b = 10;

        convertbasse(s, a, b);
    }
}
