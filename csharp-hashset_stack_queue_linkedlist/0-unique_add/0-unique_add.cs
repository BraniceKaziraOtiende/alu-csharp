﻿using System;
using System.Collections.Generic;

public class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqueSet = new HashSet<int>(myList);
        int sum = 0;

        foreach (int num in uniqueSet)
        {
            sum += num;
        }

        return sum;
    }
}
