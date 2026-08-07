namespace HashTable.Easy;

public static class FindWordsThatCanBeFormedByCharacters
{
    //"cat", "bt", "hat", "tree" }, "atach"
    public static int Run(string[] words, string chars)
    {
        Dictionary<char, int> dict = new();

        foreach (var item in chars)
        {
            if (dict.TryGetValue(item, out int count))
                dict[item] = count + 1;
            else
                dict[item] = 1;
        }

        Dictionary<char, int> wordsDict = new();

        for (int i = 0; i < words.Length; i++)
        {

        }

        return 0;
    }
}
