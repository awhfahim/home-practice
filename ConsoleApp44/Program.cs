int a = int.Parse(Console.ReadLine());
int b = 0;
for(int i = 2; i<= a; i++)
{
    if (a / i == 0)
    {
        Console.WriteLine(a);
    }
}
