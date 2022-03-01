using System;

namespace Complement
{
    public class S2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("                       ><><><><><><><><><><><>WELCOME TO 2'S COMPLEMENT CALCULATOR<><><><><><><><><><><><");
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("                                              Please Enter a 2/10/16 Base Number");
            Console.WriteLine(); Console.WriteLine();

            string Base_Number = string.Empty;
            string value = string.Empty;
            do
            {
                Console.Write("                                              Please Enter Base Number : ");
                Base_Number = Console.ReadLine();
                Console.WriteLine();
                if (Base_Number == "2")
                {
                    Console.Write("                                              Enter Your Binary Number Please : ");
                    value = Console.ReadLine();
                    int i = 0;
                    string[] arr = new string[value.Length];
                    foreach(char c in value)
                    {
                        arr[i] = Convert.ToString(c);
                        i++;
                    }
                    int t = 0;
                    for(int j = arr.Length-1; j>-1; j--)
                    {
                        if (arr[j] == "1")
                        {
                            t = j;
                            break;
                        }
                    }
                    for(int m = arr.Length-1; m>-1; m--)
                    {
                        if (m >= t)
                        {
                            arr[m] = arr[m];
                        }
                        else if(arr[m]=="0")
                        {
                            arr[m] = "1";
                        }
                        else
                        {
                            arr[m] = "0";
                        }
                    }
                    Console.WriteLine();
                    Console.Write("                                   The 2's Complement of your given Binary is : ");
                    foreach (string a in arr)
                    {
                        Console.Write(a);
                    }
                }
                else if (Base_Number == "10")
                {
                    Console.Write("                                              Enter Your Decimal Number Please : ");
                    value = Console.ReadLine();
                    int num = int.Parse(value);
                    string arr1 = string.Empty; 
                    while(num != 0)
                    {
                        int a = num / 2;
                        int b = num % 2;
                        num = a;
                        arr1 = Convert.ToString(b) + arr1;

                    }
                    int i = 0;
                    string[] arr = new string[arr1.Length];
                    foreach (char c in arr1)
                    {
                        arr[i] = Convert.ToString(c);
                        i++;
                    }
                    int t = 0;
                    for (int j = arr.Length - 1; j > -1; j--)
                    {
                        if (arr[j] == "1")
                        {
                            t = j;
                            break;
                        }
                    }
                    for (int m = arr.Length - 1; m > -1; m--)
                    {
                        if (m >= t)
                        {
                            arr[m] = arr[m];
                        }
                        else if (arr[m] == "0")
                        {
                            arr[m] = "1";
                        }
                        else
                        {
                            arr[m] = "0";
                        }
                    }
                    Console.WriteLine();
                    Console.Write("                                   The 2's Complement of your given Decimal is : ");
                    foreach (string a in arr)
                    {
                        Console.Write(a);
                    }
                }
                else if (Base_Number == "16")
                {
                    Console.Write("                                              Enter Your HEXA-DECIMAL Number Please : ");
                    value = Console.ReadLine();

                    int P = 0;
                    string[] arr2 = new string[value.Length];
                    foreach(char c in value)
                    {
                        arr2[P] = Convert.ToString(c);
                        P++;
                    }
                    int k = 0;
                    while (k < arr2.Length)
                    {
                        switch (arr2[k])
                        {
                            case "A":
                                arr2[k] = "10";
                                break;
                            case "B":
                                arr2[k] = "11";
                                break;
                            case "C":
                                arr2[k] = "12";
                                break;
                            case "D":
                                arr2[k] = "13";
                                break;
                            case "E":
                                arr2[k] = "14";
                                break;
                            case "F":
                                arr2[k] = "15";
                                break;
                            default:
                                arr2[k] = arr2[k];
                                break;
                        }
                        k++;
                    }
                    int Power = 0;
                    double sum = 0;
                    int Deci_Value = 0;
                    for (int m = arr2.Length-1; m>-1; m--)
                    {
                        sum = Convert.ToInt32(arr2[m]) * Math.Pow(16, Power);
                        Deci_Value += (int)sum;
                        Power++;
                    }

                    string arr1 = string.Empty;
                    while (Deci_Value != 0)
                    {
                        int a = Deci_Value / 2;
                        int b = Deci_Value % 2;
                        Deci_Value = a;
                        arr1 = Convert.ToString(b) + arr1;

                    }
                    int i = 0;
                    string[] arr = new string[arr1.Length];
                    foreach (char c in arr1)
                    {
                        arr[i] = Convert.ToString(c);
                        i++;
                    }
                    int t = 0;
                    for (int j = arr.Length - 1; j > -1; j--)
                    {
                        if (arr[j] == "1")
                        {
                            t = j;
                            break;
                        }
                    }
                    for (int m = arr.Length - 1; m > -1; m--)
                    {
                        if (m >= t)
                        {
                            arr[m] = arr[m];
                        }
                        else if (arr[m] == "0")
                        {
                            arr[m] = "1";
                        }
                        else
                        {
                            arr[m] = "0";
                        }
                    }
                    Console.WriteLine();
                    Console.Write("                                   The 2's Complement of your given Hexa-Decimal is : ");
                    foreach (string a in arr)
                    {
                        Console.Write(a);
                    }
                }
                else
                {
                    Console.Write("                                             Please Enter An Valid Base Number");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            while (Base_Number != "2" && Base_Number != "10" && Base_Number != "16");
        }
    }
}