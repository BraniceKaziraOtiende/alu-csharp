using System;
using System.Collections.Generic;

public class LList  // ✅ Class name changed from List to LList
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

        // Bubble sort (no LINQ, no SortedList)
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
