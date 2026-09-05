namespace String.Medium;

public static class MaximumProductOfWordLengths
{
    public static int Run(string[] words)
    {
        int max = 0;

        for (int i = 0; i < words.Length - 1; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                string current = words[i];
                string next = words[j];

                if (!current.Any(c => next.Contains(c)))
                    max = Math.Max(max, current.Length * next.Length);
            }
        }

        return max;
    }
}
