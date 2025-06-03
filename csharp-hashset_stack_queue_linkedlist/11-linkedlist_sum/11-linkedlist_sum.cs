using System.Collections.Generic;

public class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int total = 0;
        LinkedListNode<int> current = myLList.First;

        while (current != null)
        {
            total += current.Value;
            current = current.Next;
        }

        return total;
    }
}
