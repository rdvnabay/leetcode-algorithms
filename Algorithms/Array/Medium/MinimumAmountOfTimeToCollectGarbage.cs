/**
 * @id         2391
 * @title      Minimum Amount of Time to Collect Garbage
 * @topic      array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/minimum-amount-of-time-to-collect-garbage/
 */
namespace Array.Medium;

public static class MinimumAmountOfTimeToCollectGarbage
{
    //Input: garbage = ["G","P","GP","GG"], travel = [2,4,3]
    //Output: 21
    public static int Run(string[] garbage, int[] travel)
    {
        List<char> garbageCollector = new();

        foreach (var item in garbage)
        {
            foreach (var value in item)
            {
                if (!garbageCollector.Contains(value))
                    garbageCollector.Add(value);

            }
        }

        int total = 0;

        for (int i = 0; i < garbageCollector.Count; i++)
        {
            for (int j = 0; j < garbage.Length - 1; j++)
            {
                for (int k = 0; k < garbage[j].Length; k++)
                {
                    if (garbageCollector[i] == (garbage[j][k]))
                    {
                        total++;
                    }
                }
                total += travel[j];
            }
        }


        return total;
    }
}


