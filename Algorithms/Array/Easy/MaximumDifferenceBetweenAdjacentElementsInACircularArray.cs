/**
 * @id         3423
 * @title      Maximum Difference Between Adjacent Elements in a Circular Array
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-difference-between-adjacent-elements-in-a-circular-array/
 */
namespace Array.Easy;

public static class MaximumDifferenceBetweenAdjacentElementsInACircularArray
{
    public static int Run(int[] nums)
    {
        int maxResult = 0;

        for (int i = 0; i < nums.Length - 1; i++)
            maxResult = Math.Max(maxResult, Math.Abs(nums[i] - nums[i + 1]));

        maxResult = Math.Max(maxResult, Math.Abs(nums[nums.Length - 1] - nums[0]));

        return maxResult;
    }


    //Alternative solutions
    static int Solution2(int[] nums)
    {
        int maxDifference = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int nextIndex = (i + 1) % nums.Length;
            int difference = Math.Abs(nums[i] - nums[nextIndex]);
            maxDifference = Math.Max(maxDifference, difference);
        }

        return maxDifference;
    }
}
