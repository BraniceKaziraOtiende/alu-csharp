using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items
        Console.WriteLine("Number of items: " + aQueue.Count);

        // Print the first item or say it's empty
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("First item: " + aQueue.Peek());
        }

        // Add newItem before modifying the queue
        aQueue.Enqueue(newItem);

        // Check if queue contains the search item
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        if (containsSearch)
        {
            // Only one call to Dequeue is allowed
            // We'll use Dequeue() once to enter the loop
            Queue<string> tempQueue = new Queue<string>();
            string item = aQueue.Dequeue(); // First and only allowed Dequeue
            while (item != search)
            {
                // Don't enqueue items before search
                item = aQueue.Dequeue();
            }

            // After search is removed, move remaining items to tempQueue
            while (aQueue.Count > 0)
            {
                tempQueue.Enqueue(aQueue.Dequeue());
            }

            // Replace original queue
            aQueue = tempQueue;
        }

        return aQueue;
    }
}
