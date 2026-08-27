/**
 * @id         3940
 * @title      Limit Occurrences in Sorted Array
 * @topic      TwoPointers
 * @difficulty Easy
 * @link       https://leetcode.com/problems/limit-occurrences-in-sorted-array/
 */
namespace TwoPointers.Easy;

public static class LimitOccurrencesInSortedArray
{
    public static int[] Run(int[] nums, int k)
    {
        Dictionary<int, int> dict = new();
        List<int> result = new();

        foreach (int num in nums)
        {
            if (!dict.TryGetValue(num, out int count))
                dict[num] = 1;
            else
            {
                if (count < k)
                    dict[num] = count + 1;
            }
        }

        foreach (var pair in dict)
        {
            for (int i = 0; i < pair.Value; i++)
                result.Add(pair.Key);
        }

        return result.ToArray();
    }
}
