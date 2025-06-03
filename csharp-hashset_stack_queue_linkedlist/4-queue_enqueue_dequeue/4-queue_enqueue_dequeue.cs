using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print number of items
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // Print first item or "Queue is empty"
        if (aQueue.Count > 0)
            Console.WriteLine($"First item: {aQueue.Peek()}");
        else
            Console.WriteLine("Queue is empty");

        // Check if queue contains search item
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        // If search is found, create new queue with items after search
        if (containsSearch)
        {
            Queue<string> newQueue = new Queue<string>();
            string current = null;
            bool foundSearch = false;

            while (aQueue.Count > 0)
            {
                if (!foundSearch)
                {
                    current = aQueue.Dequeue(); // Only Dequeue used once
                    if (current == search)
                        foundSearch = true;
                }
                else
                {
                    newQueue.Enqueue(aQueue.Peek());
                    aQueue = new Queue<string>(aQueue.Skip(1));
                }
            }

            // Add newItem to the end
            newQueue.Enqueue(newItem);
            return newQueue;
        }

        // If search not found, just add newItem
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}