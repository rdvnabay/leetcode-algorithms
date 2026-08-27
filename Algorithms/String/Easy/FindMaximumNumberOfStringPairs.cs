/**
 * @id         2744
 * @title      Find Maximum Number of String Pairs
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-maximum-number-of-string-pairs/
 */
namespace String.Easy;

public static class FindMaximumNumberOfStringPairs
{
    public static int Run(string[] words)
    {
        int counter = 0;
        HashSet<string> set = new();

        foreach (var word in words)
        {
            string reversedWord = $"{word[1]}{word[0]}";

            if (!set.Contains(word))
            {
                if (!set.Contains(reversedWord))
                    set.Add(word);
                else
                    counter++;
            }
        }

        return counter;
    }
}


