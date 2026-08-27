/**
 * @id         3512
 * @title      Minimum Operations to Make Array Sum Divisible by K
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-operations-to-make-array-sum-divisible-by-k/
 */
namespace Math.Easy;

public static class MinimumOperationsToMakeArraySumDivisibleByK
{
    //3,9,7
    public static int Run(int[] nums, int k)
    {
        int total = 0;

        foreach (int num in nums)
            total += num;

        return total % k;
    }
}


