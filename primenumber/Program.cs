int a = int.Parse(Console.ReadLine());
int count = 0;
for(int  i = 2; i<=a; i++)
{
    if (a % i == 0)
    {
        count++;
        Console.WriteLine(count);
    }
}


