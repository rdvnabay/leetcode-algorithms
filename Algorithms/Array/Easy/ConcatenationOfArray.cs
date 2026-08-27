/**
 * @id         1929
 * @title      Concatenation of Array
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/concatenation-of-array/
 */
namespace Array.Easy;

public static class ConcatenationOfArray
{
    public static int[] Run(int[] nums)
    {
        int[] result = new int[nums.Length * 2];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[nums.Length + i] = nums[i];
        }

        return result;
    }
}


