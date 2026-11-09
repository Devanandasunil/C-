using System;

string s = Console.ReadLine()!;

int max = 0;

for(int i = 0; i < s.Length; i++)
{
    string temp = "";

    for(int j = i; j < s.Length; j++)
    {
        if (temp.Contains(s[j]))
            break;
        temp += s[j];
        max = Math.Max(max, temp.Length);
    }
}
Console.WriteLine(max);






