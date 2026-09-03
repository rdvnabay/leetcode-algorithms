/**
 * @id         2396
 * @title      Strictly Palindromic Number
 * @topic      Math
 * @difficulty Medium
 * @link       https://leetcode.com/problems/strictly-palindromic-number/
 */
using System.Text;

namespace Math.Medium;

public static class StrictlyPalindromicNumber
{
    public static bool Run(int n)
    {
        for (int i = 2; i <= n - 2; i++)
        {
            int num = n;
            StringBuilder sb = new();

            while (num > 0)
            {
                int remainder = num % i;
                num /= i;
                sb.Append(remainder);
            }

            int left = 0;
            int right = sb.Length - 1;

            while (left < right)
            {
                if (sb[left] != sb[right])
                    return false;

                left++;
                right--;
            }
        }

        return true;
    }
}
