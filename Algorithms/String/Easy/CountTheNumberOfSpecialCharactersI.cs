/**
 * @id         3120
 * @title      Count the Number of Special Characters I
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-the-number-of-special-characters-i/
 */
namespace String.Easy;

public static class CountTheNumberOfSpecialCharactersI
{
    public static int Run(string word)
    {
        HashSet<char> letters = new(word);
        int counter = 0;

        foreach (var letter in letters)
        {
            if (letters.Contains((char)(letter - 32)) || letters.Contains((char)(letter + 32)))
                counter++;
        }

        return counter / 2;
    }
}


