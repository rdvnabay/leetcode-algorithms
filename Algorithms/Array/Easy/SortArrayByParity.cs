/**
 * @id         905
 * @title      Sort Array By Parity
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sort-array-by-parity/
 */
namespace Algorithms.Array.Easy;

public static class SortArrayByParity
{
    public static int[] Run(int[] nums)
    {
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                int temp = nums[index];
                nums[index] = nums[i];
                nums[i] = temp;
                index++;
            }
        }

        return nums;
    }
}


