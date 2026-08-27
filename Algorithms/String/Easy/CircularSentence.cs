/**
 * @id         2490
 * @title      Circular Sentence
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/circular-sentence/
 */
namespace String.Easy;

public static class CircularSentence
{
    public static bool Run(string sentence)
    {
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length - 1; i++)
        {
            char lastChar = words[i][^1];
            char firstChar = words[i + 1][0];

            if (firstChar != lastChar)
                return false;
        }

        if (words[0][0] != words[^1][^1])
            return false;

        return true;
    }
}
