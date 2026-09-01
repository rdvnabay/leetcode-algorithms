namespace Greedy.Medium;

public static class PartitionLabels
{
    public static IList<int> Run(string s)
    {
        List<int> result = new();
        int firstIndex = 0;

        while (firstIndex < s.Length)
        {
            int lastIndex = s.LastIndexOf(s[firstIndex]);
            var set = s.Substring(firstIndex, lastIndex - firstIndex + 1).ToHashSet();

            foreach (var item in set)
            {
                if (s.LastIndexOf(item) > lastIndex)
                    lastIndex = s.LastIndexOf(item);
            }

            result.Add(lastIndex - firstIndex + 1);
            firstIndex = lastIndex + 1;
        }

        return result;
    }
}
