/**
 * @id         3838
 * @title      Weighted Word Mapping
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/weighted-word-mapping/
 */
namespace Array.Easy;

public static class WeightedWordMapping
{
    public static string Run(string[] words, int[] weights)
    {
        int i = 0;
        char[] result = new char[words.Length];

        foreach (var word in words)
        {
            int total = 0;

            foreach (var letter in word)
            {
                int index = letter - 'a';
                total += weights[index];
            }

            int remainder = total % 26;
            result[i] = (char)('z' - remainder);
            i++;

        }

        return new string(result);
    }
}


