using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter a number");
        int n = Convert.ToInt32(Console.ReadLine());

        int temp = n;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit * digit * digit;
            temp = temp / 10;

        }
        if (sum == n)
            Console.WriteLine("Armstrong");
        else
            Console.WriteLine("Not Armstrong");
    }
}
