using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a String");
        string s = Console.ReadLine() ?? "";
        for (int i = 0; i < s.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    count++;
                }
            }
            if (count == 1)
            {
                Console.WriteLine(s[i]);
                break;
            }
        }
    }
}

