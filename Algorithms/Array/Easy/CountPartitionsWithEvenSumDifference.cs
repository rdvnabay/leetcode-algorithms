/**
 * @id         3432
 * @title      Count Partitions with Even Sum Difference
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-partitions-with-even-sum-difference/
 */
namespace Array.Easy;

public static class CountPartitionsWithEvenSumDifference
{
    //10,10,3,7,6
    public static int Run(int[] nums)
    {
        int total = nums.Sum(x => x);

        int result = 0;
        int left = 0;
        int right = total;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            left += nums[i];
            right -= nums[i];

            if ((left - right) % 2 == 0)
                result++;
        }

        return result;
    }
}


