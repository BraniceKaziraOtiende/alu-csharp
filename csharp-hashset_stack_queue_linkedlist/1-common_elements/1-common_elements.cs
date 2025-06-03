using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> common = new HashSet<int>();

        foreach (int num in list2)
        {
            if (set1.Contains(num))
            {
                common.Add(num);
            }
        }

        List<int> result = new List<int>(common);

        // Sort manually using Bubble Sort since SortedList and LINQ are not allowed
        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = 0; j < result.Count - i - 1; j++)
            {
                if (result[j] > result[j + 1])
                {
                    // Swap
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }

        return result;
    }
}
