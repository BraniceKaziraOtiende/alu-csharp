using System.Collections.Generic;

public class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.First != null)
        {
            int value = myLList.First.Value;
            myLList.RemoveFirst();
            return value;
        }
        return 0;
    }
}
