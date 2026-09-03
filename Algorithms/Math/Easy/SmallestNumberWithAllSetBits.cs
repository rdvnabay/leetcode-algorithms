/**
 * @id         3370
 * @title      Smallest Number With All Set Bits
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/smallest-number-with-all-set-bits/
 */
namespace Math.Easy;

public static class SmallestNumberWithAllSetBits
{
    public static int Run(int n)
    {
        int exponent = (int)System.Math.Ceiling(System.Math.Sqrt(n));
        return (int)System.Math.Pow(2, exponent) - 1;
    }
}
