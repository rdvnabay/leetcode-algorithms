namespace Algorithms.Solutions.Easy;

public static class KidsWithTheGreatestNumberOfCandies
{
    public static IList<bool> Run(int[] candies, int extraCandies)
    {
        List<bool> result = new();
        int maxCandies = MaxCandies(candies);

        for (int i = 0; i < candies.Length; i++)
        {
            result.Add(candies[i] + extraCandies >= maxCandies);
        }

        return result;
    }

    public static int MaxCandies(int[] candies)
    {
        int max = candies[0];
        for (int i = 1; i < candies.Length; i++)
        {
            if (candies[i] > max)
                max = candies[i];
        }
        return max;
    }
}
