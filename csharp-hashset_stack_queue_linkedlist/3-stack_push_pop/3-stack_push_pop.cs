using System;
using System.Collections.Generic;
using System.Linq; // Needed for ToList()

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items
        Console.WriteLine($"Number of items: {aStack.Count}");

        // Print the top item or that it's empty
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"Top item: {aStack.Peek()}");

        // Check if stack contains search item
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();
            List<string> items = aStack.ToList();
            int searchIndex = items.FindIndex(x => x == search);
            
            // Use Pop() once to clear the original stack
            aStack.Pop();
            aStack.Clear();

            // Rebuild stack with remaining items
            for (int i = items.Count - 1; i >= 0; i--)
            {
                if (i > searchIndex)
                    aStack.Push(items[i]);
            }
        }

        // Add new item
        aStack.Push(newItem);
        return aStack;
    }
}
