int a = int.Parse(Console.ReadLine());
int sum = 0;
for(int i = 1; i <= a; i++)
{
    sum = sum + i;
    Console.WriteLine($"The First {a} natural number is: {i}");
}
Console.Write(sum);