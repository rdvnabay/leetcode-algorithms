/**
 * @id         2114
 * @title      Maximum Number of Words Found in Sentences
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/
 */
namespace String.Easy;

public static class MaximumNumberOfWordsFoundInSentences
{
    public static int Run(string[] sentences)
    {
        int maxWordCount = 0;

        foreach (var sentence in sentences)
        {
            int wordCount = sentence.Split(' ').Length;
            maxWordCount = Math.Max(maxWordCount, wordCount);
        }

        return maxWordCount;
    }


    //Alternative solutions
    static int Solution2(string[] sentences)
    {
        int maxWordCount = 0;

        foreach (var sentence in sentences)
        {
            int wordCount = 0;

            foreach (var letter in sentence)
            {
                if (letter == ' ')
                    wordCount++;
            }

            if (wordCount > maxWordCount)
                maxWordCount = wordCount;
        }

        return maxWordCount;
    }
}
