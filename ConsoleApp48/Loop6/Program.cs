int num = Convert.ToInt32(Console.ReadLine());
int result = 0;

for(int i = 1; i <= num; i++)
{
    result = num * i;
    Console.WriteLine($"{num} X {i} = {result}");
}
