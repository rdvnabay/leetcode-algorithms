/**
 * @id         2000
 * @title      Reverse Prefix of Word
 * @topic      TwoPointers
 * @difficulty Easy
 * @link       https://leetcode.com/problems/reverse-prefix-of-word/
 */
namespace TwoPointers.Easy;

public static class ReversePrefixOfWord
{
    public static string Run(string word, char ch)
    {
        int left = 0;
        int right = word.IndexOf(ch);
        var otherParts = word.Substring(right + 1, word.Length - right - 1);
        char[] chars = new char[right - left + 1];

        while (left <= right)
        {
            char temp = word[left];
            chars[left] = word[right];
            chars[right] = temp;
            left++;
            right--;
        }

        return new string(chars) + otherParts;
    }
}
