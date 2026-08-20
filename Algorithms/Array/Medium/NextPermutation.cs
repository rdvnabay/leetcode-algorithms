/**
 * @id         31
 * @title      Next Permutation
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/next-permutation/
 */
namespace Algorithms.Array.Medium;

public static class NextPermutation
{
    public static void Run(int[] nums)
    {
        int current = nums[0];
        bool isDescending = true;

        for (int i = 1; i < nums.Length; i++)
        {
            if (current >= nums[i])
                current = nums[i];
            else
            {
                isDescending = false;
                break;
            }
        }

        if (isDescending)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;

                left++;
                right--;
            }
        }
        else
        {
            int last = nums.Length - 1;
            int prev = nums.Length - 2;
            int temp = nums[prev];

            nums[prev] = nums[last];
            nums[last] = temp;
        }
    }
}


