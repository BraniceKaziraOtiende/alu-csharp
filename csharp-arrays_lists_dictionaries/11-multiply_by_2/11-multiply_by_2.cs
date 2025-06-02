using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> entry in myDict)
        {
            result[entry.Key] = entry.Value * 2;
        }

        return result;
    }
}
