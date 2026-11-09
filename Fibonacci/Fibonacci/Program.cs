using System;
 class Program
{
    static void Main()

    {
        long a = 0; long b = 1;
        long c;

        for(int i =1;i<=50;i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;

        }

    }
}