using MethodOverload;

string n = string.Empty;
int number = 0;
OverLoad obh = new OverLoad();
obh.Mymethod();
obh.name = " hello";
Console.WriteLine(obh.Mymethod());
Console.WriteLine(obh.Mymethod(number));
Console.WriteLine(obh.name);