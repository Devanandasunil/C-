using System;

Console.WriteLine("enter a number");
int n = Convert.ToInt32(Console.ReadLine());

int count = 0;
while (n > 0) 
{
    if(n%2 == 1)
    {
        count++;
        
    }
    n = n / 2;

}
Console.WriteLine(" set bits: " + count);
