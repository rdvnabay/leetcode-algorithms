/**
 * @id         1732
 * @title      Find the Highest Altitude
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-highest-altitude/
 */
namespace Array.Easy;

public static class FindTheHighestAltitude
{
    //-5,1,5,0,-7
    public static int Run(int[] gain)
    {
        int minValue = 0;
        int value = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            value = minValue + gain[i];
            if (value > minValue)
                minValue = value;
        }
        return 0;
    }
}
