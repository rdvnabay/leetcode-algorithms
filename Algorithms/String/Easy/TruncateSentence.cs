using System.Text;

namespace String.Easy;

public static class TruncateSentence
{
    //Hello how are you Contestant
    public static string Run(string s, int k)
    {
        StringBuilder sb = new();
        string[] words = s.Split(' ');

        foreach (var word in words)
        {
            if (k > 0)
            {
                sb.Append(word);
                sb.Append(' ');
            }
            else
                break;

            k--;
        }

        return sb.ToString().TrimEnd();
    }
}
