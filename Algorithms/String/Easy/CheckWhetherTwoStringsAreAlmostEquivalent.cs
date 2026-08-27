/**
 * @id         2068
 * @title      Check Whether Two Strings are Almost Equivalent
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/check-whether-two-strings-are-almost-equivalent/
 */
namespace String.Easy;

public static class CheckWhetherTwoStringsAreAlmostEquivalent
{
    public static bool Run(string word1, string word2)
    {
        Dictionary<char, int> dict1 = new();
        Dictionary<char, int> dict2 = new();

        foreach (var letter in word1)
            dict1[letter] = dict1.GetValueOrDefault(letter, 0) + 1;

        foreach (var letter in word2)
            dict2[letter] = dict2.GetValueOrDefault(letter, 0) + 1;

        foreach (var item in dict1)
        {
            if (dict2.TryGetValue(item.Key, out int count))
            {
                if (Math.Abs(item.Value - count) > 3)
                    return false;
            }
            else
            {
                if (item.Value > 3)
                    return false;
            }
        }

        foreach (var item in dict2)
        {
            if (dict1.TryGetValue(item.Key, out int count))
            {
                if (Math.Abs(item.Value - count) > 3)
                    return false;
            }
            else
            {
                if (item.Value > 3)
                    return false;
            }
        }

        return true;
    }
}
