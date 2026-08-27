/**
 * @id         2278
 * @title      Percentage of Letter in String
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/percentage-of-letter-in-string/
 */
namespace String.Easy;

public static class PercentageOfLetterInString
{
    public static int Run(string s, char letter)
    {
        int matchLetterCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == letter)
                matchLetterCount++;
        }

        return matchLetterCount * 100 / s.Length;
    }
}
