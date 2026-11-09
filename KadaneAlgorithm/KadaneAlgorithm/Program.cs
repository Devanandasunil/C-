using System;
class Program
{
    static void Main()
    {
        int[] a = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int sum = a[0];
        int max = a[0];


        for(int i = 1; i < a.Length; i++)
        {
            sum = Math.Max(a[i], sum + a[i]);
            max = Math.Max(max, sum);

        }
        Console.WriteLine(max);
    }
    
}