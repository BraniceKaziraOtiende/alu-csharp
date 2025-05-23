using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(System.Collections.Generic.Dictionary<string, string> myDict)
    {
        if (myDict == null || myDict.Count == 0)
            return;

        // Extract keys and sort them
        List<string> keys = new List<string>(myDict.Keys);
        keys.Sort();

        // Print key-value pairs in sorted order by key
        foreach (string key in keys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
