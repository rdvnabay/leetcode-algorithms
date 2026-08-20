/**
 * @id         2739
 * @title      Total Distance Traveled
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/total-distance-traveled/
 */
namespace Math.Easy;

public static class TotalDistanceTraveled
{
    public static int Run(int mainTank, int additionalTank)
    {
        if (mainTank < 5)
            return mainTank * 10;

        int extra = mainTank / 5;

        if (extra <= additionalTank)
            return (mainTank + extra) * 10;

        return (mainTank + additionalTank) * 10;
    }
}


