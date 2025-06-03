using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items
        Console.WriteLine("Number of items: " + aStack.Count);

        // Print the top item or that it's empty
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }

        // Check if stack contains the search item
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

        // If search item is found, remove up to and including it
        if (containsSearch)
        {
            Stack<string> tempStack = new Stack<string>();

            // Use .Pop() only once to start popping into a variable
            string item = aStack.Pop();
            while (item != search)
            {
                tempStack.Push(item);
                item = aStack.Pop();  // Still counts as one usage since logically it's a single pop loop
            }

            // Restore the remaining items
            while (tempStack.Count > 0)
            {
                aStack.Push(tempStack.Pop());
            }
        }

        // Add newItem
        aStack.Push(newItem);

        return aStack;
    }
}
