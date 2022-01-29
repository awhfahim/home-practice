int numb = 10;
int sum = 0;
int number = 0;
for(int i = 1; i<=numb; i++)
{
    Console.Write($"Number - {i}: ");
    number = int.Parse(Console.ReadLine());
    sum = sum + number;
   

}
Console.WriteLine(sum);
float aaverage = sum / 2f;
Console.WriteLine(aaverage);