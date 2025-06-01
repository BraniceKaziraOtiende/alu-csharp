using System;
using System.Collections.Generic;

public class List
{
    public static System.Collections.Generic.List<bool> DivisibleBy2(System.Collections.Generic.List<int> myList)
    {
        System.Collections.Generic.List<bool> result = new System.Collections.Generic.List<bool>();

        foreach (int number in myList)
        {
            result.Add(number % 2 == 0);
        }

        return result;
    }
}
