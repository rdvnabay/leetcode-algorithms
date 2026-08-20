/**
 * @id         1281
 * @title      Subtract the Product and Sum of Digits of an Integer
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
 */
namespace Algorithms.Math.Easy;

public static class SubtractTheProductAndSumOfDigitsOfAnInteger
{
    public static int Run(int n)
    {
        int sum = 0;
        int product = 1;

        while (n > 0)
        {
            int digit = n % 10;

            sum += digit;
            product *= digit;

            n = n / 10;
        }

        return product - sum;
    }
}


