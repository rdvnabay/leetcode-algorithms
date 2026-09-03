/**
 * @id         3550
 * @title      Smallest Index With Digit Sum Equal to Index
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/smallest-index-with-digit-sum-equal-to-index/
 */
namespace Array.Easy;

public static class SmallestIndexWithDigitSumEqualToIndex
{
    public static int Run(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int digitTotal = 0;

            while (num > 0)
            {
                int remainder = num % 10;
                digitTotal += remainder;
                num /= 10;
            }

            if (digitTotal == i)
                return i;
        }

        return -1;
    }
}
