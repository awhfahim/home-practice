using System;
class A1436
{
    public static void Main(string[] args)
    {
        int Test = int.Parse(Console.ReadLine());
        for(int k = 0; k<Test; k++)
        {
            string[] F_input = Console.ReadLine().Split(' ');
            int n = int.Parse(F_input[0]);
            int result = int.Parse(F_input[1]);

            string[] S_input = Console.ReadLine().Split(' ');
            double[] array = new double[n];
            int count = 0;
            foreach (string s in S_input)
            {
                array[count] = int.Parse(s);
                count++;
            }
            Array.Sort(array);

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    double res = array[j - 1] / j;
                    sum = sum + res;
                }
            }
            Console.WriteLine((Math.Round(sum) == result) ? "YES" : "NO");
        }
    }
}