using System.Text;

namespace Algorithms.Array.Easy.Solutions;

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
