namespace Greedy.Medium;

public static class GroupThePeopleGivenTheGroupSizeTheyBelongTo
{
    public static IList<IList<int>> Run(int[] groupSizes)
    {
        Dictionary<int, List<int>> dict = new();
        List<IList<int>> result = new();

        for (int i = 0; i < groupSizes.Length; i++)
        {
            int size = groupSizes[i];
            if (!dict.TryGetValue(size, out _))
                dict[size] = new() { i };
            else
                dict[size].Add(i);
        }

        foreach (var item in dict)
        {
            int count = item.Value.Count;
            int start = 0;

            while (count / item.Key > 0)
            {
                var values = item.Value.Skip(start).Take(item.Key).ToList();
                result.Add(values);

                count -= item.Key;
                start += item.Key;
            }
        }

        return result;
    }
}
