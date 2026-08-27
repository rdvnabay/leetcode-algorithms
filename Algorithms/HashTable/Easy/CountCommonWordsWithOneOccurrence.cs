/**
 * @id         2085
 * @title      Count Common Words With One Occurrence
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-common-words-with-one-occurrence/
 */
namespace HashTable.Easy;

public static class CountCommonWordsWithOneOccurrence
{
    public static int Run(string[] words1, string[] words2)
    {
        Dictionary<string, int> dict1 = new();
        Dictionary<string, int> dict2 = new();
        int result = 0;

        foreach (var word in words1)
            dict1[word] = dict1.GetValueOrDefault(word, 0) + 1;

        foreach (var word in words2)
            dict2[word] = dict2.GetValueOrDefault(word, 0) + 1;

        foreach (var item in dict1)
        {
            if (dict2.TryGetValue(item.Key, out int count))
            {
                if (item.Value == 1 && count == 1)
                    result++;
            }
        }

        return result;
    }
}
