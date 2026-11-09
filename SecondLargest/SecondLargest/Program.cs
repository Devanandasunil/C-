using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine()!);

        int largest = int.MinValue;
        int second = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine()!);

            if (number > largest)
            {
                second = largest;
                largest = number;
            }
            else if (number > second && number != largest)
            {
                second = number;
            }
        }

        Console.WriteLine("Second largest: " + second);
    }
}