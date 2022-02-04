using ClassPractice;

Teacher teacher = new();
teacher.age = 32;
teacher.Name = "Jalal Uddin";
teacher.Address = "Dhaka Mirpur";
teacher.GenerateNewId();


Teacher teacher1 = new();
teacher1.age = 80;
teacher1.Name = "Md Jabbar";
teacher1.Address = "Saidpur";
teacher1.GenerateNewId();

Console.WriteLine(teacher1.age);
Console.WriteLine(teacher.Name);
Console.WriteLine(teacher.id); Console.WriteLine(teacher1.id);





int x, y, s;

x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());


Add sum = new Add();
s = sum.Adds(x, y);
Console.WriteLine(s);
Console.WriteLine(sum.Sub(x,y));
Console.WriteLine(sum.something);
Console.WriteLine();





//int v = 0;
//int sum = 0;
//for(int i = 1; i<5; i++)
//{
//    for(int j = 0; j<i; j++)
//    {
//        sum = j + i + v;
//        v = sum;
//    }
//}

//Console.WriteLine(sum);