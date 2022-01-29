int a = int.Parse(Console.ReadLine());

string b = Console.ReadLine();

string[] x = b.Split(",");

int[] m = new int[a];
for(int i = 0; i < a; i++)
{
    m[i] = int.Parse(x[i]);
}
 Console.WriteLine(m[0]);














//string[] x = new string[a];
//for(int i = 0; i < x.Length; i++)
//{
//    x[i] = Console.ReadLine();

//}
//for (int i = 0; i < x.Length; i++)
//{
//    Console.WriteLine(x[i]);

//}



