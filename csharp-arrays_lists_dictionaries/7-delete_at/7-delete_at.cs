using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        List<int> newList = new List<int>();

        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
                newList.Add(myList[i]);
        }

        myList.Clear();
        foreach (int item in newList)
        {
            myList.Add(item);
        }

        return myList;
    }
}
