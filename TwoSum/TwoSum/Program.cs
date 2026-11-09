using System;
Console.WriteLine("Enter a number :");
int[] a = { 2, 7, 11, 5 };
int target = 9;

for(int i = 0; i < a.Length; i++)
{
    for(int j = i + 1; j < a.Length; j++)
    {
        if (a[i] + a[j] == target)
        {
            Console.WriteLine(i + " " + j);
        }
    }
}
