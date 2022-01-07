using System;
namespace voweldeclare
{
    public static class voweldeclare
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a alphabet");
            char ch=Convert.ToChar(Console.ReadLine());
            if(ch=='a' || ch=='A' || ch=='e' || ch=='E' || ch=='i' || ch=='I' || ch=='o' || ch=='O' || ch=='u' || ch == 'U')
            {
                Console.WriteLine(" its a vowel");
            }
            else if(ch>='a' && ch<='z' || ch>='A' && ch <= 'Z')
            {
                Console.WriteLine("This is a Consonant");
            }
            else
            {
                Console.WriteLine("This is not an alphabet");
            }



            
        }
    }
}