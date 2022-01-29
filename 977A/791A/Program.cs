using System;
class A791
{
    public static void Main(string[] args)
    {
        string weight = Console.ReadLine();

        string[] seperate = weight.Split(" ");

        int Limak = int.Parse(seperate[0]);
        int Bob = int.Parse(seperate[1]);

        int LimakWeight = 0;
        int BobWeight = 0;

        for(int i = 1; i < 10; i++)
        {
            LimakWeight = Limak * 3;
            BobWeight = Bob * 2;

            Limak = LimakWeight;
            Bob = BobWeight;

            if (LimakWeight > BobWeight)
            {
                Console.WriteLine(i);
                break;
            }

        }

    }
    
}