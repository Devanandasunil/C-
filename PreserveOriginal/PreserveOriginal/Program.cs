using System;

Console.WriteLine("Enter array size:");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
    arr[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    bool found = false;

    for (int j = 0; j < i; j++)
    {
        if (arr[i] == arr[j])
        {
            found = true;
            break;
        }
    }

    if (!found)
        Console.Write(arr[i] + " ");
}