/**
 * @id         2652
 * @title      Sum Multiples
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sum-multiples/
 */
namespace Math.Easy;

public static class SumMultiples
{
    public static int Run(int n)
    {
        int total = 0;

        for (int i = 1; i <= n; i++)
        {
            if ((i % 3 == 0) || (i % 5 == 0) || (i % 7 == 0))
                total += i;
        }

        return total;
    }
}


