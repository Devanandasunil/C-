using System;

int[] a = { 1, 2, 3, 4, 6 };
int n = a.Length + 1;

int sum = n * (n + 1) / 2;
int total = 0;

foreach(int x in a)
{
    total += x;

}
Console.WriteLine("Missing number:" + (sum - total));