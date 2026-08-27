/**
 * @id         1979
 * @title      Find Greatest Common Divisor of Array
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-greatest-common-divisor-of-array/
 */
namespace Algorithms.Math.Easy;

public static class FindGreatestCommonDivisorOfArray
{
    public static int Run(int[] nums)
    {
        System.Array.Sort(nums);
        int num1 = nums[nums.Length - 1];
        int num2 = nums[0];
        return FindEbob(num1, num2);
    }

    static int FindEbob(int num1, int num2)
    {
        while (num2 != 0)
        {
            int remainder = num1 % num2;
            num1 = num2;
            num2 = remainder;
        }
        return num1;
    }
}


