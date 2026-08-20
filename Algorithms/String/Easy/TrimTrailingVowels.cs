/**
 * @id         3856
 * @title      Trim Trailing Vowels
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/trim-trailing-vowels/
 */
namespace String.Easy;

public static class TrimTrailingVowels
{
    public static string Run(string s)
    {
        HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

        if (!vowels.Contains(s[s.Length - 1]))
            return s;

        int deleteVowelCount = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (vowels.Contains(s[i]))
                deleteVowelCount++;
            else
                break;
        }

        return s.Substring(0, s.Length - deleteVowelCount);
    }
}


