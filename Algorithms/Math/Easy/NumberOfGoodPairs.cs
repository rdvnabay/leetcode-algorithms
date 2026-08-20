/**
 * @id         1512
 * @title      Number of Good Pairs
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-good-pairs/
 */
namespace Algorithms.Math.Easy;

public static class NumberOfGoodPairs
{
    public static int Run(int[] nums)
    {
        int result = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                    result++;
            }
        }

        return result;
    }
}


