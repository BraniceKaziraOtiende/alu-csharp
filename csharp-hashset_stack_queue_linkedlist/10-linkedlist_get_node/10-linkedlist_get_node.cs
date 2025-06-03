using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // Check if index is valid
        if (n < 0 || myLList.Count <= n)
        {
            return 0;
        }

        // Start at first node
        LinkedListNode<int> currentNode = myLList.First;
        
        // Move n positions forward
        for (int i = 0; i < n; i++)
        {
            currentNode = currentNode.Next;
        }

        return currentNode.Value;
    }
}