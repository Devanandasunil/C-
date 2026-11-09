using System;
class Program
{
    static void Main()
    {
        string a = Console.ReadLine().ToLower();
        string b = Console.ReadLine().ToLower();

        char[] x = a.ToCharArray();
        char[] y = b.ToCharArray();

        Array.Sort(x);
        Array.Sort(y);

        if (new string(x) == new string(y))
            Console.WriteLine("anagram");
        else
            Console.WriteLine("not anagram");


    }
}