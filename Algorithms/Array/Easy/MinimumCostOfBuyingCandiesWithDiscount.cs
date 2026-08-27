/**
 * @id         2144
 * @title      Minimum Cost of Buying Candies With Discount
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-cost-of-buying-candies-with-discount/
 */
namespace Array.Easy;

public static class MinimumCostOfBuyingCandiesWithDiscount
{
    public static int Run(int[] cost)
    {
        System.Array.Sort(cost, (a, b) => b.CompareTo(a));
        int totalAmount = 0;

        for (int i = 0; i < cost.Length; i++)
        {
            if ((i + 1) % 3 == 0)
            {
                if (cost[i] > cost[i - 1])
                    totalAmount += cost[i];
            }
            else
            {
                totalAmount += cost[i];
            }
        }

        return totalAmount;
    }
}
