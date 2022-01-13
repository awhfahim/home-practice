using System;
namespace array3
{
    public static class array3
    {
        public static void Main(string[] args)
        {
            int[] Elements = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Elements {0} : ", i);
                Elements[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements stored in the array are : ");
            var y = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                var x = Elements[i];
                

                if (i < 3)
                {
                    y += x + ",";
                }
                else
                {
                    y += x;
                }
            }
            Console.WriteLine(y);

        }
    }
}