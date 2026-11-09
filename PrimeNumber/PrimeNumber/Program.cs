using System;
class Program
{
    static void Main()
    {
        int count = 0;
        int num = 2;

        while(count<50)
        {
            bool isPrime = true;

            for(int i = 2;i *i <= num;i++)
            {
                if(num%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime)
            {
                Console.Write(num + " ");
                count++;
            }
            num++;
        }


    }
}