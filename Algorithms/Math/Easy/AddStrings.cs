/**
 * @id         415
 * @title      Add Strings
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/add-strings/
 */
using System.Text;

namespace Algorithms.Math.Easy;

public static class AddStrings
{
    public static string Run(string num1, string num2)
    {
        int j = num2.Length - 1;
        StringBuilder sb = new();
        int hand = 0;

        for (int i = num1.Length - 1; i >= 0; i--, j--)
        {
            int total = hand;
            var digit1 = num1[i] - '0';
            total += digit1;

            if (j >= 0)
            {
                var digit2 = num2[j] - '0';
                total += digit2;
            }

            int remainder = 0;

            if (total > 9)
            {
                hand = 1;
                remainder = total % 10;
                sb.Insert(0, remainder);
            }
            else
            {
                hand = 0;
                sb.Insert(0, total);
            }
        }
        return sb.ToString();
    }
}


