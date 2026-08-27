/**
 * @id         3931
 * @title      Check Adjacent Digit Differences
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/check-adjacent-digit-differences/
 */
namespace String.Easy;

public static class CheckAdjacentDigitDifferences
{
    //129
    public static bool Run(string s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            int current = s[i] - '0';
            int next = s[i + 1] - '0';

            if (Math.Abs(current - next) > 2)
                return false;
        }

        return true;
    }
}


