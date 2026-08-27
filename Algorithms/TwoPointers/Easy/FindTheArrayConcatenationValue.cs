/**
 * @id         2562
 * @title      Find the Array Concatenation Value
 * @topic      TwoPointers
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-array-concatenation-value/
 */
namespace TwoPointers.Easy;

public static class FindTheArrayConcatenationValue
{
    public static long Run(int[] nums)
    {
        long total = 0;
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            if (left != right)
                total += long.Parse(($"{nums[left]}{nums[right]}"));
            else
                total += long.Parse(($"{nums[left]}"));

            left++;
            right--;
        }

        return total;
    }
}
