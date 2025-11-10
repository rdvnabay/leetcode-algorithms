namespace Algorithms.Solutions.Easy;

public static class MergeStringsAlternately
{
    public static string Run(string word1, string word2)
    {
        int index = 0;
        char[] merged = new char[word1.Length + word2.Length];
        int length = word1.Length >= word2.Length ? word1.Length : word2.Length;

        for (int i = 0; i < length; i++)
        {
            if (i + 1 <= word1.Length)
            {
                merged[index] = word1[i];
                index++;
            }
            if (i + 1 <= word2.Length)
            {
                merged[index] = word2[i];
                index++;
            }
        }
        
        return new string(merged);
    }
}
