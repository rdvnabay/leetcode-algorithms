/**
 * @id         1710
 * @title      Maximum Units on a Truck
 * @topic      Greedy
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-units-on-a-truck/
 */
namespace Greedy.Easy;

public static class MaximumUnitsOnATruck
{
    public static int Run(int[][] boxTypes, int truckSize)
    {
        int result = 0;
        Array.Sort(boxTypes, (a, b) => b[1].CompareTo(a[1]));

        for (int i = 0; i < boxTypes.Length; i++)
        {
            int numberOfBoxes = boxTypes[i][0];
            int numberOfUnitsPerBox = boxTypes[i][1];

            for (int j = 1; j <= numberOfBoxes; j++)
            {
                if (truckSize > 0)
                {
                    truckSize--;
                    result += numberOfUnitsPerBox;
                }
            }
        }

        return result;
    }
}
