/**
 * @id         290
 * @title      Word Pattern
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/word-pattern/
 */
namespace Algorithms.String.Easy;

public static class WordPattern
{
    public static bool Run(string pattern, string s)
    {
        Dictionary<char, string> dict = new();
        string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (pattern.Length != words.Length)
            return false;

        for (int i = 0; i < pattern.Length; i++)
        {
            if (!dict.TryGetValue(pattern[i], out string? value))
            {
                if (dict.ContainsValue(words[i]))
                    return false;

                dict.Add(pattern[i], words[i]);
            }

            else
            {
                if (value != words[i])
                    return false;
            }
        }

        return true;
    }
}


