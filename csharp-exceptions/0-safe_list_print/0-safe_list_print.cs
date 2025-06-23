using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;

        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                count++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            // When n > myList.Count, accessing myList[i] throws this exception
            // We just stop printing and return the count of printed elements
        }

        return count;
    }
}
