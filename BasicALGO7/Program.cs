string a = Console.ReadLine();
string b = Console.ReadLine();
string c = a.Substring(0,2);
string d = b.Substring(0,2);
if (d == "if")
{
    Console.WriteLine(b);

}
else
{
    Console.WriteLine("if " + b);
}
if(c == "if")
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("if " + a);
}
