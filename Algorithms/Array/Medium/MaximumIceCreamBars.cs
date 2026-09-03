namespace Array.Medium;

public static class MaximumIceCreamBars
{
    public static int Run(int[] costs, int coins)
    {
        int max = costs.Max();
        int[] countingArray = new int[max + 1];

        for (int i = 0; i < costs.Length; i++)
            countingArray[costs[i]]++;

        int buyCount = 0;
        for (int i = 0; i < countingArray.Length; i++)
        {
            if (countingArray[i] != 0)
            {
                while (coins > 0)
                {
                    while (countingArray[i] > 0)
                    {
                        coins -= i;
                        if (coins < 0)
                        {
                            return buyCount;
                        }

                        countingArray[i]--;
                        buyCount++;
                    }
                    break;
                }
            }
        }

        return buyCount;
    }
}
