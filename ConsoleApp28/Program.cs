int sum = 0;
int[] number = new int[10];
for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine("number{0} :", i);
    number[i] =int.Parse(Console.ReadLine());
    sum +=number[i];
    
}
Console.WriteLine(sum);