using System;
class A492
{
    public static void Main(string[] args)
    {
        int sum = 0;

        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                sum = sum + j; 
            }
            if (sum == num)
            {
                Console.WriteLine(i);
                break;
            }
            else if( sum>= num)
            {
                Console.WriteLine(i-1);
                break;
            }
        } 
    }
}