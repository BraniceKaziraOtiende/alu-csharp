using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0 || myLList.Count <= n)
        {
            return 0;
        }

        LinkedListNode<int> currentNode = myLList.First;
        for (int i = 0; i < n; i++)
        {
            currentNode = currentNode.Next;
        }

        return currentNode.Value;
    }
}