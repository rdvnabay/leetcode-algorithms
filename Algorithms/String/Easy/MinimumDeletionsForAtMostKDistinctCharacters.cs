/**
 * @id         3545
 * @title      Minimum Deletions for At Most K Distinct Characters
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-deletions-for-at-most-k-distinct-characters/
 */
namespace String.Easy;

public static class MinimumDeletionsForAtMostKDistinctCharacters
{
    public static int Run(string s, int k)
    {
        Dictionary<char, int> dict = new();

        for (int i = 0; i < s.Length; i++)
        {
            dict[s[i]] = dict.GetValueOrDefault(s[i], 0) + 1;
        }

        dict = dict.OrderBy(x => x.Value).ToDictionary();

        int total = 0;
        int count = dict.Count;

        foreach (var item in dict)
        {
            if (count > k)
            {
                total += item.Value;
                count--;
            }
        }

        return total;
    }
}
