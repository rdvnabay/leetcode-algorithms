/**
 * @id         2079
 * @title      Watering Plants
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/watering-plants/
 */
namespace Array.Medium;

public static class WateringPlants
{
    //2,2,3,3 -> 5
    //7,7,7,7,7,7,7  ->8 
    public static int Run(int[] plants, int capacity)
    {
        int maxCapacity = capacity;
        int totalStep = 0;

        for (int i = 0; i < plants.Length;)
        {
            int value = plants[i];
            capacity = capacity - value;

            if (capacity > 0)
            {
                i++;
                totalStep++;
            }
            else
            {
                totalStep += i * 2;
                capacity = maxCapacity;
            }
        }

        return totalStep;
    }
}


