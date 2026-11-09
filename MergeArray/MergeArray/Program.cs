using System;

int[]a = {1, 3, 5, 7, 9 };
int[]b = { 2, 4, 6, 8, 10 };

int[] c = new int[a.Length + b.Length];

int i = 0;int j = 0;int k = 0;

while(i <a.Length && j < b.Length)
{
    if (a[i] < b[j])
        c[k++] = a[i++];
    else
        c[k++] = b[j++];


}
while (i < a.Length)
    c[k++] = a[i++];
while (j < b.Length)
    c[k++] = b[j++];

Console.WriteLine(string.Join(" ", c));


