using System;
class A122
{
    public static void Main(string[] args)
    {
        string FirstLine = Console.ReadLine().ToLower();
        string SecondLine = Console.ReadLine().ToLower();
        int count = 0;

        for (int i = 0; i < FirstLine.Length; i++)
        {
            if((int)FirstLine[i] == (int)SecondLine[i]) 
            {
                count++;
            }
            else if ((int)FirstLine[i] > (int)SecondLine[i])
            {
                Console.WriteLine("1");
                break;
            }
            else if((int)FirstLine[i] < (int)SecondLine[i])
            {
                Console.WriteLine("-1");
                break;
            }
        }
        if(count == FirstLine.Length)
        {
            Console.WriteLine("0");
        }
    }
}
