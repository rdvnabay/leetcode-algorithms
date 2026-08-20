/**
 * @id         2828
 * @title      Check if a String Is an Acronym of Words
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/check-if-a-string-is-an-acronym-of-words/
 */
using System.Text;

namespace String.Easy;

public static class CheckIfAStringIsAnAcronymOfWords
{
    public static bool Run(IList<string> words, string s)
    {
        StringBuilder sb = new();

        for (int i = 0; i < words.Count; i++)
            sb.Append(words[i][0]);

        return sb.ToString() == s;
    }
}


