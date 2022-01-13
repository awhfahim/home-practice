using System;
namespace arrayelecopy
{
    public static class elementscopy
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[3];
            for(int i = 0; i < array1.Length; i++)
            {
                Console.Write("array1 {0} : ", i);
                array1[i] = int.Parse(Console.ReadLine());
                
            }
            
            int[] array2 = new int[3];
            for(int i = 0; i < array2.Length; i++)
            {
                
                array2[i] = array1[i];
            }
      
            for(int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
                Console.WriteLine("Elements are :", array2[i]);
            }
        }
    }
}