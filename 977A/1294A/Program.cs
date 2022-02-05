using System;

class A1294
{
    public static void Main(string[] args)
    {
        int FstNum = Convert.ToInt32(Console.ReadLine());

        string[] tests = new string[FstNum];
        string[] num;
        for(int i = 0; i<FstNum; i++)
        {
            tests[i] = Console.ReadLine();
            num[i] = tests[i].Split(" ");
        }
        
        //for(int i = 0; i<FstNum; i++)
        //{
        //    string[] indvdual= tests[i].Split(' ');
        //    Console.WriteLine(indvdual[1]);
        //}
        
    }
}