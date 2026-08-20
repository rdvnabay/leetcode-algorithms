/**
 * @id         238
 * @title      Product of Array Except Self
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/product-of-array-except-self/
 */
namespace Algorithms.Array.Medium;

public static class ProductOfArrayExceptSelf
{
    public static int[] Run(int[] nums)
    {
        List<int> zerosIndexes = new();
        int product = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                zerosIndexes.Add(i);
            else
            {
                product *= nums[i];
            }
        }

        if (zerosIndexes.Count > 1)
        {
            System.Array.Clear(nums, 0, nums.Length);
        }
        else if (zerosIndexes.Count == 1)
        {
            System.Array.Clear(nums, 0, nums.Length);
            nums[zerosIndexes[0]] = product;
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = product / nums[i];
            }
        }

        return nums;
    }
}


