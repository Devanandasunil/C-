
using System;

class Program
{
    static void Permute(string s, int start)
    {
        if (start == s.Length - 1)
        {
            Console.WriteLine(s);
            return;
        }

        for (int i = start; i < s.Length; i++)
        {
            char[] a = s.ToCharArray();

            (a[start], a[i]) = (a[i], a[start]);

            Permute(new string(a), start + 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine()!;

        Permute(s, 0);
    }
}
