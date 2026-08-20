/**
 * @id         1859
 * @title      Sorting the Sentence
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/sorting-the-sentence/
 */
namespace String.Easy;

public static class SortingTheSentence
{
    public static string Run(string s)
    {
        string[] words = s.Split(' ');
        string[] result = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            int order = words[i][words[i].Length - 1] - '0';
            result[order - 1] = words[i][..^1];
        }

        return string.Join(" ", result);
    }
}


