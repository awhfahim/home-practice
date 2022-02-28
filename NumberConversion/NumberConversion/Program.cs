using System;

public class Number_Conversion
{
    public static void Main(string[] args)
    {
        string Digits = Console.ReadLine();
        double current_base = int.Parse(Console.ReadLine());
        int Convert_base = int.Parse(Console.ReadLine());

        int i = 0;
        string[] arr = new string[Digits.Length];
        foreach(char c in Digits)
        {
            arr[i] = Convert.ToString(c);
            i++;
        }
        int j = 0;
        while (j < arr.Length)
        {
            switch (arr[j])
            {
                case "A":
                    arr[j] = "10";
                    break;
                case "B":
                    arr[j] = "11";
                    break;
                case "C":
                    arr[j] = "12";
                    break;
                case "D":
                    arr[j] = "13";
                    break;
                case "E":
                    arr[j] = "14";
                    break;
                case "F":
                    arr[j] = "15";
                    break;
                default:
                    arr[j] = arr[j];
                    break;
            }
            j++;
        }
        int m = 0;
        double sum = 0;
        int power = arr.Length - 1;
        while (m < arr.Length)
        {
            double value = int.Parse(arr[m]) * Math.Pow(current_base, power);
            sum += value;
            m++;
            power--;
        }
        string Answer = string.Empty;
        while(sum > 0)
        {
            double D_res = sum / Convert_base;
            double D_end = sum % D_res;
            sum = D_res;
            Answer += Convert.ToString(D_end);
        }
        Console.WriteLine(Answer);
    }
}