/**
 * @id         3712
 * @title      Sum of Elements With Frequency Divisible by K
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sum-of-elements-with-frequency-divisible-by-k/
 */
namespace HashTable.Easy;

public static class SumOfElementsWithFrequencyDivisibleByK
{
    public static int Run(int[] nums, int k)
    {
        Dictionary<int, int> dict = new();
        int total = 0;

        foreach (var num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;

        foreach (var item in dict)
        {
            if (item.Value % k == 0)
                total += item.Key * item.Value;
        }

        return total;
    }
}
