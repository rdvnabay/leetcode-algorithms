namespace Greedy.Easy;

public static class BuyTwoChocolates
{
    public static int Run(int[] prices, int money)
    {
        Array.Sort(prices);

        int twoChocolate = prices[0] + prices[1];
        if (twoChocolate > money)
            return money;


        return twoChocolate - money;
    }
}
