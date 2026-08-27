/**
 * @id         1837
 * @title      Sum of Digits in Base K
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sum-of-digits-in-base-k/
 */
namespace Math.Easy;

public static class SumOfDigitsInBaseK
{
    public static int Run(int n, int k)
    {
        int total = 0;

        while (n > 0)
        {
            total += n % k;
            n /= k;
        }

        return total;
    }
}


