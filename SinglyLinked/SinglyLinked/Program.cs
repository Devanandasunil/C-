
using System;

class Node
{
    public int data;
    public Node? next;

    public Node(int d)
    {
        data = d;
    }
}

class Program
{
    static void Main()
    {
        Node head = new Node(1);
        head.next = new Node(2);
        head.next.next = new Node(3);

        Node? prev = null, curr = head;

        while (curr != null)
        {
            Node? next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        head = prev!;

        while (head != null)
        {
            Console.Write(head.data + " ");
            head = head.next;
        }
    }
}
