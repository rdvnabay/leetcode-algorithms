/**
 * @id         2485
 * @title      Find the Pivot Integer
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-pivot-integer/
 */
namespace Algorithms.Math.Easy;

public static class FindThePivotInteger
{
    //8
    public static int Run(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int left = i * (i + 1) / 2;
            int termCount = n - i + 1;
            int right = ((n + i) * termCount) / 2;

            if (left == right)
                return i;
        }

        return -1;
    }
}


