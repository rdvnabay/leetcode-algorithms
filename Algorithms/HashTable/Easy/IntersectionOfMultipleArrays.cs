/**
 * @id         2248
 * @title      Intersection of Multiple Arrays
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/intersection-of-multiple-arrays/
 */
namespace HashTable.Easy;

public static class IntersectionOfMultipleArrays
{
    public static IList<int> Run(int[][] nums)
    {
        Dictionary<int, int> dict = new();
        List<int> result = new();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums[i].Length; j++)
            {
                int value = nums[i][j];
                dict[value] = dict.GetValueOrDefault(value, 0) + 1;
            }
        }

        foreach (var item in dict)
        {
            if (item.Value == nums.Length)
                result.Add(item.Key);
        }

        return result.Order().ToList();
    }
}
