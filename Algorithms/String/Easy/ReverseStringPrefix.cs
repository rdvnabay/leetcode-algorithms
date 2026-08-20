/**
 * @id         3794
 * @title      Reverse String Prefix
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/reverse-string-prefix/
 */
namespace String.Easy;

public static class ReverseStringPrefix
{
    public static string Run(string s, int k)
    {
        int left = 0;
        int right = k - 1;
        char[] result = s.ToCharArray();

        while (left < right)
        {
            char temp = s[left];
            result[left] = s[right];
            result[right] = temp;
            left++;
            right--;
        }

        return new string(result);
    }
}


