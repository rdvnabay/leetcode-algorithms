/**
 * @id         3745
 * @title      Maximize Expression of Three Elements
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximize-expression-of-three-elements/
 */
namespace Array.Easy;

public static class MaximizeExpressionOfThreeElements
{
    public static int Run(int[] nums)
    {
        System.Array.Sort(nums, (a, b) => b.CompareTo(a));
        int maxValue = int.MinValue;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    int total = nums[i] + nums[j] - nums[k];
                    if (total > maxValue)
                        maxValue = total;
                }
            }
        }

        return maxValue;
    }
}
