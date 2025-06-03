using System;
using System.Collections.Generic;

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
            Stack<string> newStack = new Stack<string>();
            Stack<string> tempStack = new Stack<string>();
            string item = aStack.Pop(); // Only Pop used once

            // Move items to temp stack until we find search
            while (!item.Equals(search))
            {
                tempStack.Push(item);
                item = aStack.Peek();
                newStack.Push(aStack.Peek());
                aStack = new Stack<string>(aStack.Skip(1));
            }

            // Return items after search back to main stack
            while (aStack.Count > 0)
            {
                newStack.Push(aStack.Peek());
                aStack = new Stack<string>(aStack.Skip(1));
            }

            aStack = newStack;
        }

        // Add new item
        aStack.Push(newItem);
        return aStack;
    }
}
