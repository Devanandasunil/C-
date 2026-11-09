using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        string input = Console.ReadLine() ?? "";
        var stack = new Stack<char>();
        bool balanced = true;

        foreach (char c in input)
        {
            if ("([{".Contains(c))
                stack.Push(c);
            else if (")]}".Contains(c))
            {
                if (stack.Count == 0 ||
                    "()[]{}".IndexOf($"{stack.Pop()}{c}") < 0)
                {
                    balanced = false;
                    break;
                }
            }
        }

        Console.WriteLine(balanced && stack.Count == 0 ? "Balanced" : "Not balanced");
    }
}