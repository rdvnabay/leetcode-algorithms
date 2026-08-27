/**
 * @id         3074
 * @title      Apple Redistribution into Boxes
 * @topic      Greedy
 * @difficulty Easy
 * @link       https://leetcode.com/problems/apple-redistribution-into-boxes/
 */
namespace Greedy.Easy;

public static class AppleRedistributionIntoBoxes
{
    public static int Run(int[] apple, int[] capacity)
    {
        int totalCapacity = 0;
        int totalAppleCount = 0;

        for (int i = 0; i < apple.Length; i++)
            totalAppleCount += apple[i];

        Array.Sort(capacity, (a, b) => b.CompareTo(a));

        int index = 0;
        while (totalCapacity < totalAppleCount)
        {
            totalCapacity += capacity[index];
            index++;
        }

        return index;
    }
}
