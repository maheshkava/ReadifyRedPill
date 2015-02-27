
using System;
public class Word
{
    /// <summary>
    /// given a string, this method will reverse the characters order in each word in this string, 
    /// and return a new string.
    /// </summary>
    /// <param name="originalString">the input string</param>
    /// <returns>the result string</returns>

    public string ReverseWords(string s)
    {
        if (s == null) throw new ArgumentNullException("s", "Require s != null");
        var result = new System.Text.StringBuilder(s.Length);
        int start = 0;

        while (start < s.Length)
        {
            int end = start;
            while (end < s.Length && !Char.IsWhiteSpace(s[end])) end++;
            for (int i = end - 1; i >= start; i--) result.Append(s[i]);
            start = end;
            while (start < s.Length && Char.IsWhiteSpace(s[start])) result.Append(s[start++]);
        }

        return result.ToString();
    } 

}