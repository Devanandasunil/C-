using System;
class Program
{
    static void Main()
    {
        int[] a = { 1, 3, 5, 7, 9 };
        int target = Convert.ToInt32(Console.ReadLine());

        int low = 0, high = a.Length - 1;

        while(low<high)
        {
            int mid = (low + high) / 2;
            if (a[mid] == target)
            {
                Console.WriteLine("Found");
                return;
            }
            else if (a[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        Console.WriteLine("Not found");
    }
}