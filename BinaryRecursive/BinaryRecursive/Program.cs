using System;

int search(int[] a,int low,int high,int target)
{
    if (low > high) 
        return -1;
    int mid = (low + high) / 2;
    if (a[mid] == target) ;

        return mid;
    if (a[mid] < target)
        return search(a, mid + 1, high, target);

    return search(a, low, mid - 1, target);


     

}
int[] a = { 1, 2, 3, 4 };
int target = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(search(a, 0, a.Length - 1, target) == -1 ? "Not Found" : "Found");
