namespace Algorithms.Solutions.Medium;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static int Run(string s)
    {
        List<string> substrings = new();
        string item = string.Empty;

        if (s.Length == 0) return 0;

        foreach (int index in Enumerable.Range(0, s.Length))
        {
            if (item.Contains(s[index]))
            {
                substrings.Add(item);
                item = "";

                string lastItem = substrings.Last();
                int indexOfSameChar = lastItem.IndexOf(s[index]);
                string diffPrevChars = lastItem.Substring(indexOfSameChar + 1, lastItem.Length - (indexOfSameChar + 1));
                item = diffPrevChars + s[index];
            }
            else
            {
                item += s[index];

                if (index == s.Length - 1)
                    substrings.Add(item);
            }
        }

        return substrings.Max(str => str.Length);
    }
}
