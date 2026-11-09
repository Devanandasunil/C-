using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

BlockingCollection<int> queue = new BlockingCollection<int>();

Task producer = Task.Run(() =>
{
    for (int i = 1; i <= 5; i++)
    {
        queue.Add(i);
        Console.WriteLine("Produced: " + i);
    }

    queue.CompleteAdding();
});

Task consumer = Task.Run(() =>
{
    foreach (int item in queue.GetConsumingEnumerable())
    {
        Console.WriteLine("Consumed: " + item);
    }
});

Task.WaitAll(producer, consumer);