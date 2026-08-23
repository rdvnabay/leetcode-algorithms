namespace HashTable.Easy;

public static class CheckIfNumberHasEqualDigitCountAndDigitValue
{
    public static bool Run(string num)
    {
        Dictionary<char, int> dict = new();

        foreach (var val in num)
            dict[val] = dict.GetValueOrDefault(val, 0) + 1;

        for (int i = 0; i < num.Length; i++)
        {
            char ch = (char)(num[i] + '0');
            int count = num[i];

            if (dict.TryGetValue(ch, out int value))
                if (count != value)
                    return false;
        }

        return true;
    }
}
