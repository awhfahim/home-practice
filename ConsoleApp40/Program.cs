Console.WriteLine("Enter a string input");
string word = "fahimm";
char[] a = new char[word.Length];
for (int i = 0; i < word.Length; i++)
{
    a[i] = word[i];
    Console.WriteLine($"Alphabet {i}");
}
