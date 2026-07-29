namespace Algorithms.HashTable.Easy.Solutions;

public class DistributeCandies
{
    public static int Run(int[] candyType)
    {
        int candiesToTake = candyType.Length / 2;
        int distinctCandyCount = candyType.ToHashSet().Count;

        return System.Math.Min(candiesToTake, distinctCandyCount);
    }
}
