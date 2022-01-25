string[] a = new string[5];
string b = String.Empty;
for(int i = 0; i < 5; i++)
{
    a[i] = Console.ReadLine();
    b = a[i];
    continue;
}
Console.WriteLine(b);