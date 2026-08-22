namespace HashTable.Easy;

public static class CheckIfAllCharactersHaveEqualNumberOfOccurrences
{
    public static bool Run(string s)
    {
        Dictionary<char, int> dict = new();

        foreach (var letter in s)
            dict[letter] = dict.GetValueOrDefault(letter, 0) + 1;

        return dict.All(x => x.Value == dict.First().Value);
    }
}
