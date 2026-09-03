/**
 * @id         2418
 * @title      Sort the People
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sort-the-people/
 */
namespace HashTable.Easy;

public static class SortThePeople
{
    public static string[] Run(string[] names, int[] heights)
    {
        string[] result = new string[names.Length];
        Dictionary<int, int> dict = new();

        for (int i = 0; i < names.Length; i++)
            dict[i] = heights[i];

        var orderedHeights = dict.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();

        for (int i = 0; i < orderedHeights.Length; i++)
            result[i] = names[orderedHeights[i]];

        return result;
    }
}
