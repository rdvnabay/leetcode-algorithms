/**
 * @id         1518
 * @title      Water Bottles
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/water-bottles/
 */
namespace Math.Easy;

public static class WaterBottles
{
    public static int Run(int numBottles, int numExchange)
    {
        int total = 0;

        while (numBottles > 0)
        {
            total += numBottles;
            numBottles /= numExchange;
        }

        return total;
    }
}


