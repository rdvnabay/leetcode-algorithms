/**
 * @id         3392
 * @title      Count Subarrays of Length Three With a Condition
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-subarrays-of-length-three-with-a-condition/
 */
namespace Array.Easy;

public static class CountSubarraysOfLengthThreeWithACondition
{
    public static int Run(int[] nums)
    {
        int subArrayCount = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int a = nums[i];
            int b = nums[i + 1];
            int c = nums[i + 2];

            if (a + c == (double)b / 2)
                subArrayCount++;
        }

        return subArrayCount;
    }
}
