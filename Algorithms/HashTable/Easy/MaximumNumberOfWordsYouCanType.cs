/**
 * @id         1935
 * @title      Maximum Number of Words You Can Type
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-number-of-words-you-can-type/
 */
namespace HashTable.Easy;

public static class MaximumNumberOfWordsYouCanType
{
    public static int Run(string text, string brokenLetters)
    {
        int result = 0;
        string[] words = text.Split(' ');
        HashSet<char> set = new(brokenLetters);

        foreach (var word in words)
        {
            bool canBeTyped = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (set.Contains(word[i]))
                {
                    canBeTyped = false;
                    break;
                }
            }

            if (canBeTyped)
                result++;
        }

        return result;
    }
}
