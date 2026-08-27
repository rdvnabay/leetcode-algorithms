/**
 * @id         2656
 * @title      Maximum Sum With Exactly K Elements
 * @topic      Greedy
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-sum-with-exactly-k-elements/
 */
namespace Greedy.Easy;

public static class MaximumSumWithExactlyKElements
{
    public static int Run(int[] nums, int k)
    {
        int max = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
                max = nums[i];
        }

        return ((max + k - 1) + max) * k / 2;
    }
}
