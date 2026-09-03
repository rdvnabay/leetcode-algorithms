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
    //[-5,1,5,0,-7]
    public static int Run(int[] gain)
    {
        int defaultValue = 0;
        int value = 0;
        int total = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            value = defaultValue + gain[i];
            if (value > defaultValue)
                defaultValue = value;
        }
        return 0;
    }
}
