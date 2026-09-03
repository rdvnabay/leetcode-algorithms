/**
 * @id         2788
 * @title      Split Strings by Separator
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/split-strings-by-separator/
 */
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
