﻿using System;
using System.Collections.Generic;

public class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        foreach (int num in myLList)
        {
            sum += num;
        }
        return sum;
    }
}