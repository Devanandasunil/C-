using System;
class Program
{
    static void Main()
    {
        string a = Console.ReadLine()!;
        string b = Console.ReadLine()!;

        if(a.Length == b.Length && (a+a).Contains(b))
            Console.WriteLine("rotated");
        else
            Console.WriteLine("not rotated");



    }
}