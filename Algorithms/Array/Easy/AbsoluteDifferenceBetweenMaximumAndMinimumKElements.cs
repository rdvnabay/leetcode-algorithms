/**
 * @id         3774
 * @title      Absolute Difference Between Maximum and Minimum K Elements
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/absolute-difference-between-maximum-and-minimum-k-elements/
 */
namespace Array.Easy;

public static class AbsoluteDifferenceBetweenMaximumAndMinimumKElements
{
    public static int Run(int[] nums, int k)
    {
        System.Array.Sort(nums);
        int maxTotal = 0;
        int minTotal = 0;

        for (int i = 0; i < k; i++)
        {
            minTotal += nums[i];
            maxTotal += nums[nums.Length + i - k];
        }

        return Math.Abs(maxTotal - minTotal);
    }
}
