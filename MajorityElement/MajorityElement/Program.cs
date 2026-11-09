using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 5, 5 };


        int candidate = 0;
        int count = 0;

        foreach (int num in a)
        {
            if (count == 0)
            {
                candidate = num;
            }

            if (num == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        Console.WriteLine(candidate);
    }
}
