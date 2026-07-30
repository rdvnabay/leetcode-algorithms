namespace Algorithms.Math.Easy.Solutions;

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
