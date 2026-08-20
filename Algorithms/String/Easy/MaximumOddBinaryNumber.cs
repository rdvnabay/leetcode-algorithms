/**
 * @id         2864
 * @title      Maximum Odd Binary Number
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-odd-binary-number/
 */
namespace String.Easy;

public static class MaximumOddBinaryNumber
{
    public static string Run(string s)
    {
        int countOfOne = 0;
        char[] result = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
                countOfOne++;
        }

        result[result.Length - 1] = '1';
        countOfOne--;

        for (int i = 0; i < result.Length - 1; i++)
        {
            if (countOfOne > 0)
            {
                result[i] = '1';
                countOfOne--;
            }
            else
                result[i] = '0';
        }

        return new string(result);
    }
}


