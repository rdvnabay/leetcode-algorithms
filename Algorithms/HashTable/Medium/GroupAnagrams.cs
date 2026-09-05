namespace HashTable.Medium;

public static class GroupAnagrams
{
    public static IList<IList<string>> Run(string[] strs)
    {
        List<IList<string>> result = new();
        Dictionary<string, List<string>> dict = new();

        foreach (var str in strs)
        {
            string sorted = new string(str.OrderBy(c => c).ToArray());

            if (!dict.TryGetValue(sorted, out _))
                dict[sorted] = new List<string>() { str };
            else
                dict[sorted].Add(str);
        }

        foreach (var item in dict)
            result.Add(item.Value);

        return result;
    }
}
