/**
 * @id         1486
 * @title      XOR Operation in an Array
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/xor-operation-in-an-array/
 */
namespace Algorithms.Math.Easy;

public static class XOROperationInAnArray
{
    public static int Run(int n, int start)
    {
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            int value = start + i * 2;
            result ^= value;
        }

        return result;
    }
}


