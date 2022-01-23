string a = "12345";
int sum = 0;
int x;
for(int i=0; i<a.Length; i++)
{
    x = int.Parse(a[i]); 
    sum = sum + x;
}

    Console.WriteLine(sum);
