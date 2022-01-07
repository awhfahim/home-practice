using System;
namespace alphabetcheck
{
    public static class alphabetcheck
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabet");
            char cs = Convert.ToChar(Console.ReadLine());
            switch (cs)
            {
                case 'a':
                    Console.WriteLine("This is Vowel");
                    break;
                case 'A':
                    Console.WriteLine("This is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("This is Vowel");
                    break;
                case 'E':
                    Console.WriteLine("This is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("This is Vowel");
                    break;
                case 'I':
                    Console.WriteLine("This is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("This is Vowel");
                    break;
                case 'O':
                    Console.WriteLine("This is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("This is Vowel");
                    break;
                case 'U':
                    Console.WriteLine("This is Vowel");
                    break;
                default:
                    Console.WriteLine("This is an Consonent");
                    break;
            }

        }
    }
}
