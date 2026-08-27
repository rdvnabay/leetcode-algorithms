/**
 * @id         709
 * @title      To Lower Case
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/to-lower-case/
 */
namespace Algorithms.String.Easy;

public static class ToLowerCase
{
    public static string Run(string s)
    {
        char[] characters = s.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsUpper(characters[i]))
                characters[i] = char.ToLower(characters[i]);
        }

        var result = new string(characters);
        return result;

    }
}


