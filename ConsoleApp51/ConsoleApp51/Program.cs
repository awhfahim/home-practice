// See https://aka.ms/new-console-template for more information
using ConsoleApp51;

Console.WriteLine("Hello, World!");

int num = int.Parse(Console.ReadLine());

Teacher teacher = new();
teacher.Name = "MD ABU WABAIDER HASAN Fahim";

Console.WriteLine(teacher.Name);
//Console.WriteLine(teacher.PrimeNum(num));

if(teacher.PrimeNum(num) == false)
{
    Console.WriteLine($"{num} is not a prime num");
}
else
{
    Console.WriteLine($"{num} is a prime number");
}