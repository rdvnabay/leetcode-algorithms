/**
 * @id         345
 * @title      Reverse Vowels of a String
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/reverse-vowels-of-a-string/
 */
using System.Net.Http.Headers;

namespace Algorithms.String.Easy;

public static class ReverseVowelsOfAString
{
    public static string Run(string s)
    {
        HashSet<char> vowels = new() { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        char[] result = s.ToCharArray();

        int left = 0;
        int right = s.Length - 1;

        while (left <= right)
        {
            if (vowels.Contains(s[left]) && vowels.Contains(s[right]))
            {
                result[left] = s[right];
                result[right] = s[left];
                left++;
                right--;
            }

            else if (vowels.Contains(s[left]))
                right--;

            else if (vowels.Contains(s[right]))
                left++;

            else
            {
                left++;
                right--;
            }
        }
        return new string(result);
    }
}


