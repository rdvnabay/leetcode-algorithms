/**
 * @id         2574
 * @title      Left and Right Sum Differences
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/left-and-right-sum-differences/
 */
namespace Array.Easy;

public static class LeftAndRightSumDifferences
{
    public static int[] Run(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int left = 0;
            int right = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;

                if (i < j)
                    right += nums[j];
                else
                    left += nums[j];
            }

            result[i] = Math.Abs(left - right);
        }

        return result;
    }
}


