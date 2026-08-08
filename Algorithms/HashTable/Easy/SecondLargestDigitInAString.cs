namespace HashTable.Easy;

public static class SecondLargestDigitInAString
{
    public static int Run(string s)
    {
        Dictionary<int, int> dict = new();

        foreach (var item in s)
        {
            if (char.IsDigit(item))
            {
                int num = item - '0';
                if (!dict.ContainsKey(num))
                    dict[num] = 1;
            }
        }

        if (dict.Count <= 1)
            return -1;

        return dict.OrderByDescending(x => x.Key).Skip(1).Take(1).FirstOrDefault().Key;
    }
}
