using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a String:");
        string str = Console.ReadLine();

        int left = 0;
        int right = str.Length - 1;

        bool isPalindrome = true;

        while(left<right)
        {
            if (str[left] != str[right])
            {
                isPalindrome = false;
                break;

            }
            left++;
            right--;
        }
        if (isPalindrome)
            Console.WriteLine("palindrome");
        else
            Console.WriteLine("Not");

    }
}