/**
 * @id         2206
 * @title      Divide Array Into Equal Pairs
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/divide-array-into-equal-pairs/
 */
namespace HashTable.Easy;

public static class DivideArrayIntoEqualPairs
{
    public static bool Run(int[] nums)
    {
        Dictionary<int, int> dict = new();

        foreach (int num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;

        return dict.All(x => x.Value % 2 == 0);
    }
}
