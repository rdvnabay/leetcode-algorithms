/**
 * @id         2243
 * @title      Calculate Digit Sum of a String
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/calculate-digit-sum-of-a-string/
 */
using System.Text;

namespace String.Easy;

public static class CalculateDigitSumOfAString
{
    public static string Run(string s, int k)
    {
        StringBuilder sb = new(s);

        while (sb.Length > k)
        {
            var parts = sb.ToString().Chunk(k).ToArray();
            sb.Clear();

            foreach (var part in parts)
            {
                int total = 0;

                for (int i = 0; i < part.Length; i++)
                    total += part[i] - '0';

                sb.Append(total);
            }
        }

        return sb.ToString();
    }
}


