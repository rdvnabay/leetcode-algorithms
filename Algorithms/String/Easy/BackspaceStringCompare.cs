/**
 * @id         844
 * @title      Backspace String Compare
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/backspace-string-compare/
 */
using System.Text;

namespace String.Easy;

public static class BackspaceStringCompare
{
    //ab##", "c#d#
    public static bool Run(string s, string t)
    {
        StringBuilder word1 = new();
        StringBuilder word2 = new();

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '#' || s[i + 1] == '#')
                continue;

            word1.Append(s[i]);
        }

        for (int i = 0; i < t.Length - 1; i++)
        {
            if (t[i] == '#' || t[i + 1] == '#')
                continue;

            word2.Append(t[i]);
        }

        return word1.ToString() == word2.ToString();
    }
}


