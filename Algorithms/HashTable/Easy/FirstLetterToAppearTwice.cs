/**
 * @id         2351
 * @title      First Letter to Appear Twice
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/first-letter-to-appear-twice/
 */
namespace HashTable.Easy;

public static class FirstLetterToAppearTwice
{
    public static char Run(string s)
    {
        HashSet<char> set = new();
        char result = ' ';

        foreach (var letter in s)
        {
            if (!set.Add(letter))
            {
                result = letter;
                break;
            }
        }

        return result;
    }
}
