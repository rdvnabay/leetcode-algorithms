namespace Algorithms.HashTable.Easy.Solutions;

public class LongestHarmoniousSubsequence
{
    public static int Run(int[] nums)
    {
        int max = 0;
        Dictionary<int, int> dict = new();

        foreach (var num in nums)
        {
            if (!dict.ContainsKey(num))
                dict.Add(num, 1);
            else
                dict[num]++;
        }


        foreach (var item in dict)
        {
            int number = item.Key;
            int currentNumberCount = item.Value;

            if (dict.TryGetValue(number + 1, out int nextNumberCount))
            {
                int total = currentNumberCount + nextNumberCount;
                max = System.Math.Max(max, total);
            }
        }

        return max;
    }
}