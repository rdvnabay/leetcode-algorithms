using System.Text;

namespace String.Easy;

public static class CheckIfAStringIsAnAcronymOfWords
{
    public static bool Run(IList<string> words, string s)
    {
        StringBuilder sb = new();

        for (int i = 0; i < words.Count; i++)
            sb.Append(words[i][0]);

        return sb.ToString() == s;
    }
}
