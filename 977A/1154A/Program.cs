using System;

class A1154
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int h = 0;
        int b = 0;

        string[] vs = input.Split(' ');

        int[] vs1 = new int[vs.Length];
        for(int i = 0; i < vs.Length; i++)
        {
            vs1[i] = int.Parse(vs[i]);
            
        }
        for(int i =0; i < vs1.Length; i++)
        {
            if(vs1[i] > h)
            {
                h = vs1[i];
                b = i;
            }
        }
        for(int i =0; i < vs1.Length; i++)
        {
            if( b!= i)
            {
                Console.Write("{0} ", h-vs1[i]);
            }
        }
    }
}
