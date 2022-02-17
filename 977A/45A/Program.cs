using System;

class A45
{
    public static void Main(string[] args)
    {
        string Input = Console.ReadLine();
        int S_Input = int.Parse(Console.ReadLine());
        int Month = 0;
        int New_Month = 0;

        string[] array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        for(int i = 0; i<array.Length; i++)
        {
            if(Input == array[i])
            {
                Month = i;
            }
        }
        int Appear = S_Input + Month;
        if (Appear <= 11)
        {
            Console.WriteLine(array[Appear]);
        }
        else if (Appear > 11)
        {
            New_Month = Appear % 12;
            Console.WriteLine(array[New_Month]);
        }
    }
}