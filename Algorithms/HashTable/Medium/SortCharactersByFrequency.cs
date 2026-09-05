using System.Text;

namespace HashTable.Medium;

public static class SortCharactersByFrequency
{
    public static string Run(string s)
    {
        StringBuilder result = new();
        Dictionary<char, int> dict = new();

        foreach (char c in s)
            dict[c] = dict.GetValueOrDefault(c, 0) + 1;

        var orderedDict = dict.OrderByDescending(x => x.Value).ToList();
        
        foreach (var item in orderedDict)
            result.Append(item.Key, item.Value);

        return result.ToString();
    }
}
