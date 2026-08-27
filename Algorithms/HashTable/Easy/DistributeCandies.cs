/**
 * @id         575
 * @title      Distribute Candies
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/distribute-candies/
 */
namespace Algorithms.HashTable.Easy;

public class DistributeCandies
{
    public static int Run(int[] candyType)
    {
        int candiesToTake = candyType.Length / 2;
        int distinctCandyCount = candyType.ToHashSet().Count;

        return System.Math.Min(candiesToTake, distinctCandyCount);
    }
}


