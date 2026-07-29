namespace Algorithms.DynamicProgramming.Easy.Solutions;

public class MinCostClimbingStairs
{
    public static int Run(int[] cost)
    {
        int result1 = CalculateCost(cost, 0);
        int result2 = CalculateCost(cost, 1);

        return System.Math.Min(result1, result2);
    }

    static int CalculateCost(int[] cost, int startIndex)
    {
        int total = 0;
        int lastIndex = cost.Length - 1;
        for (int i = startIndex; i <= lastIndex;)
        {
            int current = cost[i];
            total += current;

            if (i == lastIndex)
                return total;

            else if (i + 1 == lastIndex)
                return total;

            else
            {

                if (cost[i + 1] < cost[i + 2])
                {
                    if (i + 2 + 1 == lastIndex)
                    {
                        int value1 = cost[i + 1] + cost[i + 3];
                        int value2 = cost[i+2];

                        int minValue = System.Math.Min(value1, value2);
                        total += minValue;
                        return total;
                    }
                    else
                        i += 1;
                }

                else if (cost[i + 1] >= cost[i + 2])
                    i += 2;
            }

        }
        return total;
    }
}
