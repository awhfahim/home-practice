string str = "512 4";

string[] str2 = str.Split(' ');

int x = int.Parse(str2[0]);
int y = int.Parse(str2[1]);
Console.WriteLine($"{x},{y}");

