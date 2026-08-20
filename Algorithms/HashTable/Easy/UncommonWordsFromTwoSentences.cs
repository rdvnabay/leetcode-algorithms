/**
 * @id         884
 * @title      Uncommon Words from Two Sentences
 * @topic      hash-table
 * @difficulty Easy
 * @link       https://leetcode.com/problems/uncommon-words-from-two-sentences/
 */
namespace Algorithms.HashTable.Easy;

public static class UncommonWordsFromTwoSentences
{
    public static string[] Run(string s1, string s2)
    {
        string sentence = $"{s1} {s2}";
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dict = new();

        foreach (string word in words)
        {
            if (dict.TryGetValue(word, out int count))
                dict[word] = count + 1;
            else
                dict[word] = 1;
        }

        List<string> result = new();

        foreach (var item in dict)
        {
            if (item.Value == 1)
                result.Add(item.Key);
        }

        return result.ToArray();
    }

    //Other solutions
    public static string[] Solution2(string s1, string s2)
    {
        string sentence = $"{s1} {s2}";
        var words = sentence.Split(' ', options: StringSplitOptions.RemoveEmptyEntries);

        return words
            .GroupBy(word => word)
            .Where(x => x.Count() == 1)
            .Select(x => x.Key)
            .ToArray();
    }
}


