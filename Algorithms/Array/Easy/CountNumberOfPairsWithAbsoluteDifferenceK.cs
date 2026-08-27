/**
 * @id         2006
 * @title      Count Number of Pairs With Absolute Difference K
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-number-of-pairs-with-absolute-difference-k/
 */
namespace Array.Easy;

public static class CountNumberOfPairsWithAbsoluteDifferenceK
{
    //1, 2, 2, 1 }, 1
    public static int Run(int[] nums, int k)
    {
        int total = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) == k)
                    total++;
            }
        }

        return total;
    }
}


