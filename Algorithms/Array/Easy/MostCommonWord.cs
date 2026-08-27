/**
 * @id         819
 * @title      Most Common Word
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/most-common-word/
 */
using System.Text;

namespace Algorithms.Array.Easy;

public static class MostCommonWord
{
    public static string Run(string paragraph, string[] banned)
    {


        StringBuilder sb = new StringBuilder();

        foreach (char c in paragraph)
        {
            if (!char.IsPunctuation(c))
            {
                sb.Append(c);
            }
        }

        string temizMetin = sb.ToString();
        Console.WriteLine(temizMetin);
        return "";
    }
}


