/**
 * @id         1967
 * @title      Number of Strings That Appear as Substrings in Word
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-strings-that-appear-as-substrings-in-word/
 */
namespace String.Easy;

public static class NumberOfStringsThatAppearAsSubstringsInWord
{
    //Input: patterns = ["a","abc","bc","d"], word = "abc"
    //Output: 3
    public static int Run(string[] patterns, string word)
    {
        int counter = 0;

        foreach (var pattern in patterns)
        {
            foreach (var letter in pattern)
            {
                if (word.Contains(letter))
                {
                    counter++;
                    break;
                }
            }
        }

        return counter;
    }
}
