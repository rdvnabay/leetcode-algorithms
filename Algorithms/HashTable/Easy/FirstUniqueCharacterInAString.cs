namespace Algorithms.HashTable.Easy;

public static class FirstUniqueCharacterInAString
{
    public static int Run(string s)
    {
        Dictionary<char, (int Index, int Count)> dict = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.TryGetValue(s[i], out var value))
                dict.Add(s[i], (i, 1));
            else
                dict[s[i]] = (value.Index, value.Count += 1);
        }

        foreach (var item in dict)
        {
            if (item.Value.Count == 1)
                return item.Value.Index;
        }

        return -1;
    }
}
