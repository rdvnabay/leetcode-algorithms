namespace HashTable.Medium;

public static class MinimumLengthOfStringAfterOperations
{
    public static int Run(string s)
    {
        Dictionary<char, int> dict = new();

        foreach (var c in s)
            dict[c] = dict.GetValueOrDefault(c, 0) + 1;

        int operationCount = 0;

        foreach (var item in dict)
        {
            if (item.Value % 2 == 0)
                operationCount += 2;
            else
                operationCount += 1;
        }

        return operationCount;
    }
}
