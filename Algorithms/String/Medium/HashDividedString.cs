/**
 * @id         3271
 * @title      Hash Divided String
 * @topic      String
 * @difficulty Medium
 * @link       https://leetcode.com/problems/hash-divided-string/
 */
using System.Text;

namespace String.Medium;

public static class HashDividedString
{
    public static string Run(string s, int k)
    {
        StringBuilder result = new();

        int start = 0;
        int end = k;
        int counter = s.Length / k;

        while (counter > 0)
        {
            int total = 0;

            for (int i = start; i < end; i++)
            {
                total += s[i] - 'a';
            }

            char letter = (char)((total % 26) + 'a');
            result.Append(letter);
            counter--;
            start += k;
            end += k;
        }

        return result.ToString();
    }
}
