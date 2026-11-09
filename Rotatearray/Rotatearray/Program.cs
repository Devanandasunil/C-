using System;

int[] a = { 1, 2, 3, 4, 5 };

Console.WriteLine("Enter k:");
int k = Convert.ToInt32(Console.ReadLine());

k = k % a.Length;

for (int j = 0; j < k; j++)
{
    int last = a[a.Length - 1];

    for (int i = a.Length - 1; i > 0; i--)
    {
        a[i] = a[i - 1];
    }

    a[0] = last;
}

foreach (int x in a)
{
    Console.Write(x + " ");
}