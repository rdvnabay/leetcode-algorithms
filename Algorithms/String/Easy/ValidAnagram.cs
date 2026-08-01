namespace Algorithms.String.Easy;

public static class ValidAnagram
{
    public static bool Run(string s, string t)
    {
        SortedDictionary<char, int> result1 = new();
        SortedDictionary<char, int> result2 = new();

        if (s.Length != t.Length)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            if (!result1.ContainsKey(s[i]))
                result1.Add(s[i], 1);
            else
                result1[s[i]]++;

            if (!result2.ContainsKey(t[i]))
                result2.Add(t[i], 1);
            else
                result2[t[i]]++;
        }

        return result1.SequenceEqual(result2);
    }
}
