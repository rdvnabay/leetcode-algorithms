/**
 * @id         1464
 * @title      Maximum Product of Two Elements in an Array
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/
 */
namespace Array.Easy;

public static class MaximumProductOfTwoElementsInAnArray
{
    public static int Run(int[] nums)
    {
        int maxValue = int.MinValue;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int value = (nums[i] - 1) * (nums[j] - 1);
                if (value > maxValue)
                    maxValue = value;
            }
        }

        return maxValue;
    }
}


