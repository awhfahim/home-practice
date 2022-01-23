int r = 0;
int k = 0;
int a = 0;

int num = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < num; i++)
{
    if (num % i == 0)
    {
        r = i;

        for (int j = 1; j <= r; j++)
        {
            if (r % j == 0)
            {
                k++;
            }
            
        }
        if (k == 2)
            {
                Console.WriteLine(r);
            }
        k = 0;
    }
}




