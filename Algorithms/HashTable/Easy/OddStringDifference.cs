/**
 * @id         2451
 * @title      Odd String Difference
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/odd-string-difference/
 */
namespace HashTable.Easy;

public static class OddStringDifference
{
    //"adc", "wzy", "abc" 
    public static string Run(string[] words)
    {
        Dictionary<string, List<int>> dict = new();
        Dictionary<int, int> dict2 = new();

        foreach (var word in words)
        {
            List<int> items = new();

            dict[word] = dict.GetValueOrDefault(word, items);

            for (int i = 1; i < word.Length; i++)
            {
                int diff = word[i] - word[i - 1];

                if (!dict2.TryGetValue(diff, out int count))
                    dict2[diff] = 1;
                else
                    dict2[diff] = count + 1;

                items.Add(diff);
            }

            var test = dict2.MinBy(x => x.Value);
            var a = "";

        }
        return "";
    }
}
