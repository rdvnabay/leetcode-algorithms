using System.Text;

namespace String.Easy;

public static class CheckIfTwoStringArraysAreEquivalent
{
    public static bool Run(string[] word1, string[] word2)
    {
        StringBuilder sbWord1 = new();
        StringBuilder sbWord2 = new();

        for (int i = 0; i < word1.Length; i++)
            sbWord1.Append(word1[i]);


        for (int i = 0; i < word2.Length; i++)
            sbWord2.Append(word2[i]);

        return sbWord1.ToString() == sbWord2.ToString();
    }
}
