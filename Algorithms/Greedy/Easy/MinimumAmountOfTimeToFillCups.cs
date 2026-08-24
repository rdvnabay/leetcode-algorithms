namespace Greedy.Easy;

public static class MinimumAmountOfTimeToFillCups
{
    //1,4,2
    public static int Run(int[] amount)
    {
        int counter = 0;

        int coldCup = amount[0];
        int warmCup = amount[1];
        int hotCup = amount[2];

        int total = coldCup + warmCup + hotCup;

        while (total > 0)
        {
            if (coldCup + warmCup == 0)
            {
                hotCup--;
                counter++;
            }
            if (coldCup + hotCup == 0)
            {
                warmCup--;
                counter++;
            }
            if (warmCup + hotCup == 0)
            {
                coldCup--;
                counter++;
            }
            
            
        }

        return 0;
    }
}
