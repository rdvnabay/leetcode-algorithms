/**
 * @id         2325
 * @title      Decode the Message
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/decode-the-message/
 */
using System.Text;

namespace String.Easy;

public static class DecodeTheMessage
{
    public static string Run(string key, string message)
    {
        HashSet<char> set = key.ToHashSet();
        Dictionary<char, char> dict = new();

        int index = 0;
        foreach (var letter in set)
        {
            if (char.IsWhiteSpace(letter))
                continue;

            dict[letter] = (char)('a' + index);
            index++;
        }

        StringBuilder result = new();
        foreach (var letter in message)
        {
            if (char.IsWhiteSpace(letter))
                result.Append(letter);
            else
                result.Append(dict[letter]);
        }

        return result.ToString();
    }
}
