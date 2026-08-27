/**
 * @id         2390
 * @title      Removing Stars From a String
 * @topic      String
 * @difficulty Medium
 * @link       https://leetcode.com/problems/removing-stars-from-a-string/
 */
using System.Text;

namespace String.Medium;

public static class RemovingStarsFromAString
{
    public static string Run(string s)
    {
        StringBuilder result = new();

        foreach (char character in s)
        {
            if (character == '*')
                result.Length--;
            else
                result.Append(character);
        }

        return result.ToString();
    }


    //Alternative solutions
    static string Solution2(string s)
    {
        StringBuilder sb = new(s);

        for (int i = 0; i < sb.Length - 1;)
        {
            if (sb[i] != '*' && sb[i + 1] == '*')
            {
                sb.Remove(i, 2);
                i--;

                if (i == -1)
                    i = 0;
            }
            else
            {
                i++;
            }
        }

        return sb.ToString();
    }

}
