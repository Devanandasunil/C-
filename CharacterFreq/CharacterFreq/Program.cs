using System;

string s = Console.ReadLine()!;
foreach(char c in s.Distinct())
{
    Console.WriteLine(c + "=" + s.Count(x => x == c));


}