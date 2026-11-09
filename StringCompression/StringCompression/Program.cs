using System;

string s = Console.ReadLine()!;

string result = "";
int count = 1;

for(int i = 1; i < s.Length; i++)
{
    if (s[i] == s[i - 1])
        count++;
    else
    {
        result += s[i - 1] + count.ToString();
        count = 1;

    }
}

if(s.Length>0)
    result += s[s.Length - 1] + count.ToString();

Console.WriteLine(result);
