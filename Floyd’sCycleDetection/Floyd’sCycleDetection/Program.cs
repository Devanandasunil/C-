
using System;

class Node
{
    public int data;
    public Node? next;

    public Node(int data)
    {
        this.data = data;
    }
}

class Program
{
    static void Main()
    {
        Node first = new Node(10);
        Node second = new Node(20);
        Node third = new Node(30);
        Node fourth = new Node(40);

        first.next = second;
        second.next = third;
        third.next = fourth;
        fourth.next = second; // Creates a cycle

        Node? slow = first;
        Node? fast = first;

        while (fast != null && fast.next != null)
        {
            slow = slow!.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                Console.WriteLine("Cycle exists");
                return;
            }
        }

        Console.WriteLine("No cycle");
    }
}
