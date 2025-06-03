using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        HashSet<int> resultSet = new HashSet<int>();

        // Add elements in set1 but not in set2
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                resultSet.Add(num);
            }
        }

        // Add elements in set2 but not in set1
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                resultSet.Add(num);
            }
        }

        List<int> result = new List<int>(resultSet);

        // Manual sorting using Bubble Sort (since LINQ and SortedList not allowed)
        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = 0; j < result.Count - i - 1; j++)
            {
                if (result[j] > result[j + 1])
                {
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }

        return result;
    }
}
