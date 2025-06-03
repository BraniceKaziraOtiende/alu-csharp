using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n < 0)
            return 0;

        LinkedListNode<int> current = myLList.First;
        int index = 0;

        while (current != null)
        {
            if (index == n)
                return current.Value;

            current = current.Next;
            index++;
        }

        return 0; // n is out of range
    }
}
