using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        myDict[key] = value;  // Add or update key with value
        return myDict;
    }
}
