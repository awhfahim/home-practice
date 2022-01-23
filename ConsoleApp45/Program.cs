string str = "How are you";
Console.WriteLine(str[4]);
//char[] ch = new char[str.Length];
//for(int i = 0; i < str.Length; i++)
//{
//    ch[i] = str[i];

//}
//foreach (char c in ch)
//{
//    Console.WriteLine(c);
//}
string part = str.Substring(3, 5);
Console.WriteLine(part);