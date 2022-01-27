int v = int.Parse(Console.ReadLine());
string g = "I hate that I Love that ";
int r = 0;
if (v % 2 == 0)
{
    r = v / 2;
    for(int i = 0; i < r-1; i++)
    {
        Console.Write(g);
        
    }
    Console.Write("I hate that I Love it");
}
