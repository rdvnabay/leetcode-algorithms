/**
 * @id         1047
 * @title      Remove All Adjacent Duplicates In String
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
 */
namespace Algorithms.String.Easy;

public static class RemoveAllAdjacentDuplicatesInString
{
    public static string Run(string s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            char current = s[i];
            char next = s[i + 1];

            if (current == next)
            {
                s = s.Remove(i, 2);
                i = -1;
            }
        }
        return s;
    }
}


