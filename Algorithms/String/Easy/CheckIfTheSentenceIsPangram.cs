/**
 * @id         1832
 * @title      Check if the Sentence Is Pangram
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/check-if-the-sentence-is-pangram/
 */
namespace String.Easy;

public static class CheckIfTheSentenceIsPangram
{
    public static bool Run(string sentence)
    {
        HashSet<char> alphabet = new(sentence);
        return alphabet.Count == 26;
    }
}


