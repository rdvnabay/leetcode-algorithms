/**
 * @id         2108
 * @title      Find First Palindromic String in the Array
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-first-palindromic-string-in-the-array/
 */
namespace String.Easy;

public static class FindFirstPalindromicStringInTheArray
{
    public static string Run(string[] words)
    {
        foreach (var word in words)
        {
            int left = 0;
            int right = word.Length - 1;
            bool isPalindrome = true;

            while (left <= right)
            {
                if (word[left] == word[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }

            if(isPalindrome)
                return word;
        }

        return "";
    }
}


