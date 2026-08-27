/**
 * @id         1011
 * @title      Capacity To Ship Packages Within D Days
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/
 */
namespace Array.Medium;

public static class CapacityToShipPackagesWithinDDays
{
    //1,2,3,4,5,6,7,8,9,10  days:5
    public static int Run(int[] weights, int days)
    {
        int average = weights.Sum() / days;

        var (dayCount, maxCapacity) = Test(weights, days, average);
        while (dayCount != days)
        {
            var result = Test(weights, days, average++);
            dayCount = result.dayCount;
            maxCapacity = result.maxCapacity;
        }


        return 0;
    }

    static (int dayCount, int maxCapacity) Test(int[] weights, int days, int average)
    {
        int capacity = 0;
        int dayCount = 1;
        int maxCapacity = 0;

        foreach (var weight in weights)
        {
            capacity += weight;
            if (capacity <= average)
            {
                if (capacity > maxCapacity)
                    maxCapacity = capacity;
            }
            else
            {
                dayCount++;
                capacity = weight;
            }
        }

        return (dayCount, maxCapacity);
    }
}
