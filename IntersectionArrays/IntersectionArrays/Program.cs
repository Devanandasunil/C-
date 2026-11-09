using System;

int[] a = { 1, 2, 3, 4, 5 };
int[] b = { 4, 5, 6, 7, 8 };

for(int i = 0; i < a.Length; i++)
{ 
    
    for(int j = 0; j < b.Length; j++)
    {
        if (a[i] == b[j])
        {
            Console.WriteLine(a[i]);
            break;
        }
    }
}


