/**
 * @id         3146
 * @title      Permutation Difference between Two Strings
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/permutation-difference-between-two-strings/
 */
namespace HashTable.Easy;

public static class PermutationDifferenceBetweenTwoStrings
{
    public static int Run(string s, string t)
    {
        int total = 0;
        Dictionary<char, int> dict = new();

        for (int i = 0; i < t.Length; i++)
            dict[t[i]] = i;
        
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.TryGetValue(s[i],out int index))
                total += Math.Abs(i - index);
        }

        return total;
    }
}
