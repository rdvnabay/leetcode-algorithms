/**
 * @id         1480
 * @title      Running Sum of 1d Array
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/running-sum-of-1d-array/
 */
namespace Array.Easy;

public static class RunningSumOf1dArray
{
    public static int[] Run(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
            nums[i] = nums[i - 1] + nums[i];
       
        return nums;
    }
}


