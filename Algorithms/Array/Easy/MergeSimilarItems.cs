namespace Array.Easy;

public static class MergeSimilarItems
{
    public static IList<IList<int>> Run(int[][] items1, int[][] items2)
    {
        Dictionary<int, int> dict = new();

        foreach (var item in items1)
            dict[item[0]] = dict.GetValueOrDefault(item[0], 0) + item[1];

        foreach (var item in items2)
            dict[item[0]] = dict.GetValueOrDefault(item[0], 0) + item[1];

        return dict
           .OrderBy(x => x.Key)
           .Select(x => (IList<int>)new List<int> { x.Key, x.Value })
           .ToList();
    }
}
