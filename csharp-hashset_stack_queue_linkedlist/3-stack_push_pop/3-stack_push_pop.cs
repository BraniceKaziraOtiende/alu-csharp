﻿using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items in the stack
        Console.WriteLine($"Number of items: {aStack.Count}");

        // Print the top item if the stack is not empty
        if (aStack.Count == 0)
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        // Check if the stack contains the search item
        bool containsSearch = aStack.Contains(search);

        string item = "";

        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count == 0)
        {
            item = "Stack is empty";
        }
        else
        {
            item = "Top item: " + aStack.Peek();
        }
        Console.WriteLine(item);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        while (aStack.Contains(search))
        {
            aStack.Pop();
        }
        aStack.Push(newItem);

        return aStack;








        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

        // If the search item is found, remove all items up to and including it
        if (containsSearch)
        {
            // Use a list to hold the items temporarily
            Stack<string> tempStack = new List<string>();
            bool found = false;

            // Transfer items from the stack to the list until the search item is found
            while (aStack.Count > 0) && aStack.peek
            {
                string item = aStack.Pop(); // This is the only .Pop() used
                if (item == search)
                {
                    found = true;
                    break;
                }
                tempList.Add(item);
            }

            // Push the remaining items back to the stack in the original order
            for (int i = tempList.Count - 1; i >= 0; i--)
            {
                aStack.Push(tempList[i]);
            }
        }

        // Add the new item to the stack
        aStack.Push(newItem);

        // Return the modified stack
        return aStack;
    }
}