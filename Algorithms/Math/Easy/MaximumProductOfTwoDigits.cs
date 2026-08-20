/**
 * @id         3536
 * @title      Maximum Product of Two Digits
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-product-of-two-digits/
 */
namespace Math.Easy;

public static class MaximumProductOfTwoDigits
{
    //124
    public static int Run(int n)
    {
        int first = 0;
        int second = 0;

        while (n > 0)
        {
            int remainder = n % 10;

            if (remainder > first)
                first = remainder;

            else if (remainder > second)
                second = remainder;

            n /= 10;
        }

        return first * second;
    }
}


