/**
 * @id         1662
 * @title      Check If Two String Arrays are Equivalent
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
 */
using System.Text;

namespace String.Easy;

public static class CheckIfTwoStringArraysAreEquivalent
{
    public static bool Run(string[] word1, string[] word2)
    {
        StringBuilder sbWord1 = new();
        StringBuilder sbWord2 = new();

        for (int i = 0; i < word1.Length; i++)
            sbWord1.Append(word1[i]);


        for (int i = 0; i < word2.Length; i++)
            sbWord2.Append(word2[i]);

        return sbWord1.ToString() == sbWord2.ToString();
    }
}


