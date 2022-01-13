using System;
namespace array3
{
    public static class array3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("find the sum of all elements of array");
            
            int[] Elements = new int[3];
            for(int i = 0; i <3; i++)
            {
                Console.Write("Elements {0} : ", i);
                Elements[i] =int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum is");
            int sum = 0;
            for (int i = 0; i < 3; i++)

            {
                
                sum += Elements[i];
                
            }
            Console.WriteLine(sum);



        }
    }
}