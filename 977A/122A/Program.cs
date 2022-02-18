using System;
class A122
{
    public static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        string Input = Convert.ToString(input);
        int count = 0;
        int q = 0;

        for(int u = 0; u < 1;)
        {
            for (int h = 0; h < Input.Length; h++)
            {
                if (Input.Contains("4") && Input.Contains("7") && !Input.Contains("0") && !Input.Contains("1") && !Input.Contains("2") && !Input.Contains("3")
                    && !Input.Contains("5") && !Input.Contains("6") && !Input.Contains("8") && !Input.Contains("9") && !Input.Contains("0"))
                {
                    q++;
                }
            }
            if (q == Input.Length)
            {
                Console.WriteLine("YES");
                break;
            }
            if (Input.Length == 1)
            {
                if (Input == "4" || Input == "7" || Input == "8")
                {
                    Console.WriteLine("YES");
                    break;
                }
                else
                {
                    Console.WriteLine("NO");
                    break;
                }

            }
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    count++;
                }
            }
            int j = 0;
            int[] array = new int[count];
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    array[j] = i;
                    j++;
                }
            }
            int g = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == 4 || array[i] == 7 || array[i] == 44 || array[i] == 47 || array[i] == 74 || array[i] == 77)
                {
                    if (input % array[i] == 0)
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                }
                else
                {
                    g++;
                }
                if(g == array.Length)
                {
                    Console.WriteLine("NO");
                }
            
            }
            break;
        }
    }
}