/**
 * @id         2057
 * @title      Smallest Index With Equal Value
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/smallest-index-with-equal-value/
 */
namespace Array.Easy;

public static class SmallestIndexWithEqualValue
{
    public static int Run(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 10 == nums[i])
                return i;
        }

        return -1;
    }
}
