/**
 * @id         1207
 * @title      Unique Number of Occurrences
 * @topic      hash-table
 * @difficulty Easy
 * @link       https://leetcode.com/problems/unique-number-of-occurrences/
 */
namespace Algorithms.HashTable.Easy;

public static class UniqueNumberOfOccurrences
{
    public static bool Run(int[] arr)
    {
        Dictionary<int, int> dict = new();
        HashSet<int> values = new();

        foreach (var item in arr)
        {
            if (dict.TryGetValue(item, out int count))
                dict[item] = count + 1;
            else
                dict[item] = 1;
        }

        foreach (var value in dict.Values)
        {
            values.Add(value);
        }

        return dict.Count == values.Count;
    }
}


