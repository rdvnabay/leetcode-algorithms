/**
 * @id         2103
 * @title      Rings and Rods
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/rings-and-rods/
 */
namespace HashTable.Easy;

public static class RingsAndRods
{
    public static int Run(string rings)
    {
        Dictionary<char, HashSet<char>> dict = new();

        for (int i = 0; i < rings.Length; i += 2)
        {
            char color = rings[i];
            char rod = rings[i + 1];

            if (!dict.TryGetValue(rod, out _))
                dict[rod] = new HashSet<char>();

            dict[rod].Add(color);
        }

        return dict.Count(x => x.Value.Count == 3);
    }
}
