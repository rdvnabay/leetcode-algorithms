namespace HashTable.Easy;

public static class MostFrequentEvenElement
{
    public static int Run(int[] nums)
    {
        Dictionary<int, int> dict = new();

        foreach (int num in nums)
        {
            if (num % 2 == 0)
                dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        }

        if (dict.Count == 0)
            return -1;

        return dict
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .Select(x => x.Key)
            .FirstOrDefault();
    }
}
