using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();

        // Add elements from list1 that are not in list2
        foreach (int num in list1)
        {
            if (!list2.Contains(num))
            {
                result.Add(num);
            }
        }

        // Add elements from list2 that are not in list1
        foreach (int num in list2)
        {
            if (!list1.Contains(num))
            {
                result.Add(num);
            }
        }

        // Sort the result list using bubble sort
        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = 0; j < result.Count - i - 1; j++)
            {
                if (result[j] > result[j + 1])
                {
                    // Swap elements
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }

        return result;
    }
}
