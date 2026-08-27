/**
 * @id         1877
 * @title      Minimize Maximum Pair Sum in Array
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/minimize-maximum-pair-sum-in-array/
 */
namespace Array.Medium;

public static class MinimizeMaximumPairSumInArray
{
    public static int Run(int[] nums)
    {
        System.Array.Sort(nums, (a, b) => b.CompareTo(a));

        int left = 0;
        int right = nums.Length - 1;
        int maxValue = 0;

        while (left < right)
        {
            int total = nums[left] + nums[right];
            if (total > maxValue)
                maxValue = total;

            left++;
            right--;
        }

        return maxValue;
    }
}
