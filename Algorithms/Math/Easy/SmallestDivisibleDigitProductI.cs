/**
 * @id         3345
 * @title      Smallest Divisible Digit Product I
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/smallest-divisible-digit-product-i/
 */
namespace Math.Easy;

public static class SmallestDivisibleDigitProductI
{
    public static int Run(int n, int t)
    {
        int product = 1;
        int current = n;

        while (current > 0)
        {
            product *= current % 10;
            current /= 10;
        }

        if (product % t == 0)
            return n;

        return Run(n + 1, t);
    }
}


