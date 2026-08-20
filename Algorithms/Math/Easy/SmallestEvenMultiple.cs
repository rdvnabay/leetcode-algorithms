/**
 * @id         2413
 * @title      Smallest Even Multiple
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/smallest-even-multiple/
 */
namespace Algorithms.Math.Easy;

public static class SmallestEvenMultiple
{
    public static int Run(int n)
    {
        return n % 2 == 0 ? n : n * 2;
    }
}


