/**
 * @id         628
 * @title      Maximum Product of Three Numbers
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-product-of-three-numbers/
 */
namespace Algorithms.Array.Easy;

public class MaximumProductOfThreeNumbers
{
    public static int Run(int[] nums)
    {
        System.Array.Sort(nums);
        int lastIndex = nums.Length - 1;

        var result1 = nums[0] * nums[1] * nums[lastIndex];
        var result2 = nums[lastIndex - 2] * nums[lastIndex - 1] * nums[lastIndex];

        return System.Math.Max(result1, result2);
    }
}


