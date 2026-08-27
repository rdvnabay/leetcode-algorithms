/**
 * @id         3769
 * @title      Sort Integers by Binary Reflection
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sort-integers-by-binary-reflection/
 */
using System.Numerics;

namespace Array.Easy;

public static class SortIntegersByBinaryReflection
{
    public static int[] Run(int[] nums)
    {
        int[] reversedNums = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int reversed = 0;
            int exponent = BitOperations.Log2((uint)num);

            while (num > 0)
            {
                int remainder = num % 2;
                reversed += (int)Math.Pow(2, exponent) * remainder;
                num /= 2;
                exponent--;
            }

            reversedNums[i] = reversed;
        }

        System.Array.Sort(reversedNums, nums);
        return nums;
    }
}
