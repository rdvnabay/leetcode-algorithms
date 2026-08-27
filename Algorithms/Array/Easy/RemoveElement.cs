/**
 * @id         27
 * @title      Remove Element
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/remove-element/
 */
namespace Algorithms.Array.Easy;

public class RemoveElement
{
    public static int Run(int[] nums, int val)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}



