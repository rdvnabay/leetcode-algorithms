/**
 * @id         1748
 * @title      Sum of Unique Elements
 * @topic      hash-table
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sum-of-unique-elements/
 */
namespace Algorithms.HashTable.Easy;

public static class SumOfUniqueElements
{
    public static int Run(int[] nums)
    {
        int total = 0;
        Dictionary<int, int> dict = new();

        foreach (var num in nums)
        {
            if (!dict.TryGetValue(num, out int count))
                dict[num] = 1;
            else
                dict[num] = count + 1;
        }

        foreach (var item in dict)
            if (item.Value == 1)
                total += item.Key;

        return total;
    }
}


