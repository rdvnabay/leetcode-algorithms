/**
 * @id         2710
 * @title      Remove Trailing Zeros From a String
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/remove-trailing-zeros-from-a-string/
 */
namespace String.Easy;

public static class RemoveTrailingZerosFromAString
{
    public static string Run(string num)
    {
        if (num[num.Length - 1] != '0')
            return num;

        int zeroCount = 0;

        for (int i = num.Length - 1; i >= 0; i--)
        {
            if (num[i] == '0')
                zeroCount++;
            else
                break;
        }

        return num.Substring(0, num.Length - zeroCount);
    }
}


