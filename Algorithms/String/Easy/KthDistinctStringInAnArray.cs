namespace String.Easy;

public static class KthDistinctStringInAnArray
{
    public static string Run(string[] arr, int k)
    {
        Dictionary<string, int> dict = new();
        List<string> distinct = new();

        foreach (var item in arr)
        {
            if (!dict.TryGetValue(item, out int count))
                dict[item] = 1;
            else
                dict[item] = count + 1;
        }

        foreach (var item in dict)
        {
            if (item.Value == 1)
                distinct.Add(item.Key);
        }

        if (k > distinct.Count)
            return "";

        return distinct[k - 1];
    }
}
