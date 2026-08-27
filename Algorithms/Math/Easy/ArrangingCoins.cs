/**
 * @id         441
 * @title      Arranging Coins
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/arranging-coins/
 */
namespace Algorithms.Math.Easy;

public static class ArrangingCoins
{
    public static int Run(int n)
    {
        long total = 0;
        int counter = 0;

        while (total <= n)
        {
            counter++;
            total += counter;
        }

        return counter - 1;
    }
}


