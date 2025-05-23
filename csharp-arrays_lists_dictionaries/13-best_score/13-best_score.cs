using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(System.Collections.Generic.Dictionary<string, int> myList)
    {
        if (myList == null || myList.Count == 0)
            return "None";

        string bestKey = null;
        int maxScore = -1;

        foreach (var kvp in myList)
        {
            if (kvp.Value > maxScore)
            {
                maxScore = kvp.Value;
                bestKey = kvp.Key;
            }
        }

        return bestKey ?? "None";
    }
}
