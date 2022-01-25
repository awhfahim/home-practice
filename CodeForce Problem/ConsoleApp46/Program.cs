int count = 0;
//int n = int.Parse(Console.ReadLine());
string s = Console.ReadLine();
for(int i = 0; i < s.Length; i++)
{
    for(int j = 1; j < s.Length; j++)
    {
        if (s[i] == s[j])
        {
            count++;
        }
        
    }
    

}
if (count == 7)
{
    Console.WriteLine("yes");
    }
else
{
    Console.WriteLine("No");
}
