/**
 * @id         3264
 * @title      Final Array State After K Multiplication Operations I
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/final-array-state-after-k-multiplication-operations-i/
 */
namespace Array.Easy;

public static class FinalArrayStateAfterKMultiplicationOperationsI
{
    public static int[] Run(int[] nums, int k, int multiplier)
    {
        while (k > 0)
        {
            int minValue = int.MaxValue;
            int minValueIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < minValue)
                {
                    minValue = nums[i];
                    minValueIndex = i;
                }
            }

            nums[minValueIndex] = minValue * multiplier;
            k--;
        }

        return nums;
    }
}
