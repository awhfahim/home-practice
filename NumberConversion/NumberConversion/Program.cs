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
        int dec = (int)sum;
        string Answer = string.Empty;
        while(dec > 0)
        {
            int D_res = dec / Convert_base;
            string D_end = Convert.ToString(dec % Convert_base);
            switch (D_end)
            {
                case "10":
                    D_end = "A";
                    break;
                case "11":
                    D_end = "B";
                    break;
                case "12":
                    D_end = "C";
                    break;
                case "13":
                    D_end = "D";
                    break;
                case "14":
                    D_end = "E";
                    break;
                case "15":
                    D_end = "F";
                    break;
                default:
                    D_end = D_end;
                    break;
            }
            dec = D_res;
            Answer += D_end;
        }
        string vari = string.Empty;
        foreach(char c in Answer)
        {
             vari = c+vari;
        }
        Console.WriteLine(vari);
    }
} 