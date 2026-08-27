/**
 * @id         3467
 * @title      Transform Array by Parity
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/transform-array-by-parity/
 */
namespace Array.Easy;

public static class TransformArrayByParity
{
    public static int[] Run(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                result[left] = 0;
                left++;
            }
            else
            {
                result[right] = 1;
                right--;
            }
        }

        return result;
    }
}


