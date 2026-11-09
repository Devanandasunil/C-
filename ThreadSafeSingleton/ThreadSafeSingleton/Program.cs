using System;

class Singleton
{
    private static readonly Singleton instance = new Singleton();
    private Singleton() { }
    public static Singleton Instance => instance;
}   
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(Singleton.Instance == Singleton.Instance);
    }
}