/**
 * @id         2389
 * @title      Longest Subsequence With Limited Sum
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/longest-subsequence-with-limited-sum/
 */
namespace HashTable.Easy;

public static class LongestSubsequenceWithLimitedSum
{
    public static int[] Run(int[] nums, int[] queries)
    {
        int[] result = new int[queries.Length];
        Array.Sort(nums);

        for (int i = 0; i < queries.Length; i++)
        {
            int query = queries[i];
            int count = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                int num = nums[j];
                if (query < num)
                    continue;

                count++;

                query -= num;
                if (query <= 0)
                    break;
            }

            result[i] = count;
        }

        return result;
    }
}
