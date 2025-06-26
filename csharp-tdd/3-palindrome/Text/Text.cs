using System;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return false;

            // Remove all non-alphanumeric characters and convert to lowercase
            string cleaned = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

            // Compare the cleaned string with its reverse
            char[] arr = cleaned.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            return cleaned == reversed;
        }
    }
}
