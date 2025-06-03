using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        // If list is empty, just add and return the node
        if (myLList.First == null)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }

        LinkedListNode<int> current = myLList.First;

        // Traverse until we find a node with value greater than n
        while (current != null && current.Value < n)
        {
            current = current.Next;
        }

        if (current == null)
        {
            // Reached the end, add last
            myLList.AddLast(n);
            return myLList.Last;
        }
        else
        {
            // Insert before current node
            return myLList.AddBefore(current, n);
        }
    }
}
