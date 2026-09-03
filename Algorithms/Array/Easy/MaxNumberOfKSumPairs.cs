namespace Array.Easy;

public static class MaxNumberOfKSumPairs
{
    public static int Run(int[] nums, int k)
    {
        int matchCount = 0;
        Dictionary<int, int> dict = new();

        foreach (var num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;

        foreach (var item in dict)
        {
            int match = k - item.Key;

            if (dict.ContainsKey(match))
            {
                dict[item.Key]--;
                dict[match]--;

                if ((dict[item.Key] >= 0) && (dict[match] >= 0))
                    matchCount++;
            }
        }

        return matchCount;
    }
}
