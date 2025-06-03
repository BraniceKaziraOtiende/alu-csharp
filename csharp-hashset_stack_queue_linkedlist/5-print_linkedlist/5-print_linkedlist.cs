using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> list = new LinkedList<int>();

        if (size < 0)
            return list;  // return empty list if size is negative

        for (int i = 0; i < size; i++)
        {
            list.AddLast(i);
            Console.WriteLine(i); // Print the item
        }

        return list;
    }
}
