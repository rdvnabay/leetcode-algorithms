namespace Array.Easy;

public static class SplitStringsBySeparator
{
    public static IList<string> Run(IList<string> words, char separator)
    {
        List<string> result = new();

        foreach (var word in words)
        {
            string[] parts = word.Split(separator);
            foreach (var part in parts)
            {
                if (!string.IsNullOrEmpty(part))
                    result.Add(part);
            }
        }

        return result;
    }
}
