namespace HashTable.Easy;

public static class CountPairsOfSimilarStrings
{
    //"aba","aabb","abcd","bac","aabc"
    public static int Run(string[] words)
    {
        List<HashSet<char>> set = new();

        foreach (var word in words)
        {
            HashSet<char> set2 = new(word);
            set.Add(set2);
        }
        return 0;
    }
}
