/**
 * @id         2506
 * @title      Count Pairs Of Similar Strings
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-pairs-of-similar-strings/
 */
namespace HashTable.Easy;

public static class CountPairsOfSimilarStrings
{
    //"aba","aabb","abcd","bac","aabc"
    public static int Run(string[] words)
    {
        List<HashSet<char>> set = new();

        foreach (var word in words)
        {
            HashSet<char> set2 = new(word);
            set.Add(set2);
        }
        return 0;
    }
}
