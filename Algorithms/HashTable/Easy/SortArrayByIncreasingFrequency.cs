namespace HashTable.Easy;

public static class SortArrayByIncreasingFrequency
{
    public static int[] Run(int[] nums)
    {
        List<int> result = new();
        Dictionary<int, int> dict = new();

        foreach (var num in nums)
        {
            if (!dict.TryGetValue(num, out int count))
                dict[num] = 1;
            else
                dict[num] = count + 1;
        }

        var orderedDict = dict.OrderBy(x => x.Value).ThenByDescending(x => x.Key);

        foreach (var item in orderedDict)
            result.AddRange(Enumerable.Repeat(item.Key, item.Value));

        return result.ToArray();
    }
}
