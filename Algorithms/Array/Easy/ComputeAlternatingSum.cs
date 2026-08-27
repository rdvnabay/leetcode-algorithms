/**
 * @id         3701
 * @title      Compute Alternating Sum
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/compute-alternating-sum/
 */
namespace Array.Easy;

public static class ComputeAlternatingSum
{
    public static int Run(int[] nums)
    {
        int evenIndexSum = 0;
        int oddIndexSum = 0;

        for (int i = 0; i < nums.Length; i += 2)
            evenIndexSum += nums[i];

       
        for (int i = 1; i < nums.Length; i += 2)
            oddIndexSum += nums[i];

        return evenIndexSum - oddIndexSum;
    }
}


