namespace Algorithms.HashTable.Easy.Solutions;

public static class FindTheDifference
{
    public static char Run(string s, string t)
    {
        Dictionary<char, int> result1 = new();
        Dictionary<char, int> result2 = new();
        char resultChar = default;

        BuildFrequency(result1, s);
        BuildFrequency(result2, t);

        foreach (var item in result2)
        {
            bool isCharFound = result1.TryGetValue(item.Key, out int value);

            if (!isCharFound || item.Value != value)
            {
                resultChar = item.Key;
                break;
            }
        }

        return resultChar;
    }

    static void BuildFrequency(Dictionary<char, int> dict, string s)
    {
        foreach (var c in s)
        {
            if (!dict.TryGetValue(c, out int count))
                dict.Add(c, 1);
            else
                dict[c] = count + 1;
        }
    }
}
