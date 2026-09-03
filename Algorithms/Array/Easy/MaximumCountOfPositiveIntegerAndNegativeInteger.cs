/**
 * @id         2529
 * @title      Maximum Count of Positive Integer and Negative Integer
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-count-of-positive-integer-and-negative-integer/
 */
namespace Array.Easy;

public static class MaximumCountOfPositiveIntegerAndNegativeInteger
{
    public static int Run(int[] nums)
    {
        int zerosCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            if (num < 0)
                negativeCount++;
            else if (num == 0)
                zerosCount++;
            else
                break;
        }

        int positiveCount = nums.Length - negativeCount - zerosCount;

        return Math.Max(positiveCount, negativeCount);
    }
}
