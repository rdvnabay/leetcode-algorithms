/**
 * @id         1399
 * @title      Count Largest Group
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-largest-group/
 */
namespace Algorithms.Math.Easy;

public static class CountLargestGroup
{
    public static int Run(int n)
    {
        Dictionary<int, int> dict = new();
        int maxCount = 0;

        for (int i = 1; i <= n; i++)
        {
            int total = 0;
            int value = i;

            while (value > 0)
            {
                total += value % 10;
                value = value / 10;
            }

            if (!dict.TryGetValue(total, out int count))
                dict.Add(total, 1);
            else
                dict[total] = count + 1;

            if (maxCount < dict[total])
                maxCount = dict[total];
        }

        return dict.Values.Count(x => x == maxCount);
    }
}


