/**
 * @id         1408
 * @title      String Matching in an Array
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/string-matching-in-an-array/
 */
namespace String.Easy;

public static class StringMatchingInAnArray
{
    //"mass","as","hero","superhero"
    public static IList<string> Run(string[] words)
    {
        HashSet<string> result = new();

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (i == j)
                    continue;

                if (words[i].Length >= words[j].Length)
                    continue;
            }
        }
        return null;
    }
}
