namespace String.Easy;

public static class OccurrencesAfterBigram
{
    public static string[] Run(string text, string first, string second)
    {
        List<string> result = new();
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length - 2; i++)
        {
            if (words[i] == first && words[i + 1] == second)
                result.Add(words[i + 2]);
        }

        return result.ToArray();
    }
}
