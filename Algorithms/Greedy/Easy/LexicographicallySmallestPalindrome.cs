/**
 * @id         2697
 * @title      Lexicographically Smallest Palindrome
 * @topic      Greedy
 * @difficulty Easy
 * @link       https://leetcode.com/problems/lexicographically-smallest-palindrome/
 */
namespace Greedy.Easy;

public static class LexicographicallySmallestPalindrome
{
    public static string Run(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        char[] result = new char[s.Length];

        while (left <= right)
        {
            char replaceChar = ' ';

            if (s[left] > s[right])
                replaceChar = s[right];

            else if (s[left] < s[right])
                replaceChar = s[left];

            else
                replaceChar = s[left];

            result[left] = replaceChar;
            result[right] = replaceChar;

            left++;
            right--;
        }

        return new string(result);
    }
}
