/**
 * @id         268
 * @title      Missing Number
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/missing-number/
 */
namespace Algorithms.Math.Easy;

public static class MissingNumber
{
    public static int Run(int[] nums)
    {
        int numsTotal = nums.Sum();
        int allNumberTotal = Enumerable.Range(0, nums.Length + 1).Sum();

        return allNumberTotal - numsTotal;
    }
}


