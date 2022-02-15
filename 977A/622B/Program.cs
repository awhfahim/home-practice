using System;
class B622
{
    public static void Main(string[] args)
    {
        for(int i = 0; i < 1;)
        {
            string[] input = Console.ReadLine().Split(":");
            int AddMin = int.Parse(Console.ReadLine());

            int Hour = int.Parse(input[0]);
            int Min = int.Parse(input[1]);

            int NewMin = AddMin + Min;
            int NewHour = 0;
            int NewMin2 = 0;
            if (NewMin % 60 == 0)
            {
                NewHour = NewMin / 60;
            }
            else if (NewMin % 60 != 0)
            {
                NewHour = NewMin / 60;
                NewMin2 = NewMin - (NewHour * 60);
            }

            NewHour = NewHour + Hour;

            if (NewHour == 24)
            {
                NewHour = 0;
                if (NewMin2 < 10)
                {
                    Console.WriteLine($"0{NewHour}:0{NewMin2}");
                    break;
                }
                Console.WriteLine($"0{NewHour}:{NewMin2}");
                break;
            }
            else if (NewHour > 24)
            {
                NewHour = NewHour % 24;
                if (NewHour < 10)
                {
                    if (NewMin2 < 10)
                    {
                        Console.WriteLine($"0{NewHour}:0{NewMin2}");
                        break;
                    }
                    Console.WriteLine($"0{NewHour}:{NewMin2}");
                    break;
                }
                if (NewMin2 < 10)
                {
                    Console.WriteLine($"{NewHour}:0{NewMin2}");
                    break;
                }
                Console.WriteLine($"{NewHour}:{NewMin2}");
                break;
            }
            else if (NewHour < 10)
            {
                if (NewMin2 < 10)
                {
                    Console.WriteLine($"0{NewHour}:0{NewMin2}");
                    break;
                }
                Console.WriteLine($"0{NewHour}:{NewMin2}");
                break;
            }

            if (NewMin2 < 10)
            {
                Console.WriteLine($"{NewHour}:0{NewMin2}");
                break;
            }
            Console.WriteLine($"{NewHour}:{NewMin2}");
            break;
        }

    }
}