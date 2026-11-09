using System;
class Program
{
    static void Main()
    {
        Console.Write("enter words: ");
        String s = Console.ReadLine()!;
        string[] words = s.Split(' ');

        Array.Reverse(words);

        Console.WriteLine(String.Join(" ", words));

    }
}