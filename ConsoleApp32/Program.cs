int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int [,] rowclm = new int [a, b];
for(int i = 0; i < a; i++)
{
    for(int j = 0; j < b; j++)
    {
        Console.Write($"Input the Value of array {i},{j} : ");
        rowclm[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
for(int i = 0; i < a; i++)
{
    int sum = 0;
    for (int j =0; j < b; j++)
    {
        sum += rowclm[i,j];
    }
    Console.WriteLine(sum);

}
for(int i = 0; i < a; i++)
{
    int sum = 0;
    for(int j = 0; j < b; j++)
    {
        sum += rowclm[j,i];
    }
    Console.WriteLine(sum);
}

