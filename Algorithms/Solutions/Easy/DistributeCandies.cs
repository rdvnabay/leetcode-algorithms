namespace Algorithms.Solutions.Easy;

public class DistributeCandies
{
    public static int Run(int[] candyType)
    {
        int candiesToTake = candyType.Length / 2;
        int distinctCandyCount = candyType.ToHashSet().Count;

        return Math.Min(candiesToTake, distinctCandyCount);
    }
}
