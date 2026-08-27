/**
 * @id         3741
 * @title      Minimum Distance Between Three Equal Elements II
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/minimum-distance-between-three-equal-elements-ii/
 */
namespace Array.Medium;

public static class MinimumDistanceBetweenThreeEqualElementsII
{
    public static int Run(int[] nums)
    {
        Dictionary<int, List<int>> dict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.TryGetValue(nums[i], out _))
                dict[nums[i]] = new List<int>() { i };
            else
                dict[nums[i]].Add(i);
        }

        int minValue = int.MaxValue;

        foreach (var item in dict)
        {
            if (item.Value.Count >= 3)
            {
                for (int i = 0; i < item.Value.Count - 2; i++)
                {
                    int value = (item.Value[i + 2] - item.Value[i]) * 2;
                    if (value < minValue)
                        minValue = value;
                }
            }
        }

        return minValue == int.MaxValue ? -1 : minValue;
    }
}
