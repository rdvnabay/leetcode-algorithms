/**
 * @id         1920
 * @title      Build Array from Permutation
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/build-array-from-permutation/
 */
namespace Array.Easy;

public static class BuildArrayFromPermutation
{
    public static int[] Run(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
            result[i] = nums[nums[i]];

        return result;
    }
}


