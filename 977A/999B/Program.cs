using System;

class B999
{
    public static void Main(string[] args)
    {
        int Input = int.Parse(Console.ReadLine());
        string S_string = Console.ReadLine();

        
        for (int i = 2; i <= Input; i++)
        {
            if (Input % i == 0)
            {
                string b = string.Empty;
                string a = S_string.Substring(0,i);
                string d = S_string.Substring(i);
                for(int j = i - 1; j > -1; j--)
                {
                    b = b + a[j];
                }
                S_string = b + d;
               
            }
            
        }
        Console.WriteLine(S_string);
    }
}
