/**
 * @id         3798
 * @title      Largest Even Number
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/largest-even-number/
 */
namespace String.Easy;

public static class LargestEvenNumber
{
    public static string Run(string s)
    {
        int deletedOddCount = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int value = s[i] - '0';

            if (value % 2 == 1)
                deletedOddCount++;
            else
                return s.Substring(0, s.Length - deletedOddCount);
        }

        return "";
    }
}


