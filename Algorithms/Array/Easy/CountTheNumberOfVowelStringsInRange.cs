namespace Array.Easy;

public static class CountTheNumberOfVowelStringsInRange
{
    public static int Run(string[] words, int left, int right)
    {
        int count = 0;
        HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

        for (int i = left; i <= right; i++)
        {
            if (vowels.Contains(words[i][0]) && vowels.Contains(words[i][^1]))
                count++;
        }

        return count;
    }
}
