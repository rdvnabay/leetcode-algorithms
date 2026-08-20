/**
 * @id         557
 * @title      Reverse Words in a String III
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/reverse-words-in-a-string-iii/
 */
using System.Reflection.Emit;
using System.Text;

namespace Algorithms.String.Easy;

public static class ReverseWordsInAStringIII
{
    public static string Run(string s)
    {
        StringBuilder sb = new();
        string[] words = s.Split(' ');

        foreach (var word in words)
        {
            int index = 0;
            char[] reversedChars = new char[word.Length];

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedChars[index] = word[i];
                index++;
            }

            sb.Append(new string(reversedChars));
            sb.Append(" ");
        }

        return sb.ToString().TrimEnd();
    }
}


