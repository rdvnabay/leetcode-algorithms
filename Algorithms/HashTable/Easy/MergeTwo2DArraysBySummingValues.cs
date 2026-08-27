/**
 * @id         2570
 * @title      Merge Two 2D Arrays by Summing Values
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/merge-two-2d-arrays-by-summing-values/
 */
namespace HashTable.Easy;

public static class MergeTwo2DArraysBySummingValues
{
    public static int[][] Run(int[][] nums1, int[][] nums2)
    {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums1.Length; i++)
        {
            int id = nums1[i][0];
            int value = nums1[i][1];

            if (!dict.TryGetValue(id, out int totalValue))
                dict[id] = value;
            else
                dict[id] = totalValue + value;
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            int id = nums2[i][0];
            int value = nums2[i][1];

            if (!dict.TryGetValue(id, out int totalValue))
                dict[id] = value;
            else
                dict[id] = totalValue + value;
        }

        int[][] result = new int[dict.Count][];

        for (int i = 0; i < result.Length; i++)
            result[i] = new int[2];

        int index = 0;
        foreach (var item in dict)
        {
            result[index][0] = item.Key;
            result[index][1] = item.Value;
            index++;
        }

        return result.OrderBy(x => x[0]).ToArray();
    }
}
