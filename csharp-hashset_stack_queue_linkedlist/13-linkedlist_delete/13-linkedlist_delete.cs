using System.Collections.Generic;

public class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null || myLList.First == null || index < 0)
            return;

        LinkedListNode<int> current = myLList.First;
        int currentIndex = 0;

        // Traverse to the node at position index
        while (current != null && currentIndex < index)
        {
            current = current.Next;
            currentIndex++;
        }

        // If current is null, index is out of range, do nothing
        if (current == null)
            return;

        // Remove the node at index
        myLList.Remove(current);
    }
}
