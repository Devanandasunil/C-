using System;
using System.Collections.Generic;

class LRUCache
{
    int capacity;

    Dictionary<int, LinkedListNode<(int, int)>> map = new();
    LinkedList<(int, int)> list = new();

    public LRUCache(int c)
    {
        capacity = c;
    }

    public int Get(int key)
    {
        if (!map.ContainsKey(key))
            return -1;

        var node = map[key];
        list.Remove(node);
        list.AddFirst(node);

        return node.Value.Item2;
    }

    public void Put(int key, int value)
    {
        if (map.ContainsKey(key))
        {
            list.Remove(map[key]);
        }
        else if (map.Count == capacity)
        {
            var last = list.Last!;
            map.Remove(last.Value.Item1);
            list.RemoveLast();
        }

        list.AddFirst((key, value));
        map[key] = list.First!;
    }
}

class Program
{
    static void Main()
    {
        LRUCache cache = new LRUCache(2);

        cache.Put(1, 10);
        cache.Put(2, 20);

        Console.WriteLine(cache.Get(1));

        cache.Put(3, 30);

        Console.WriteLine(cache.Get(2));
        Console.WriteLine(cache.Get(3));
    }
}