/**
 * @id         3110
 * @title      Score of a String
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/score-of-a-string/
 */
namespace String.Easy;

public static class ScoreOfAString
{
    public static int Run(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length - 1; i++)
            result += Math.Abs(s[i] - s[i + 1]);

        return result;
    }
}


