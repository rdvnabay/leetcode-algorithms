namespace Algorithms.HashTable.Easy;

public static class LongestPalindrome
{
    public static int Run(string s)
    {
        int result = 0;
        bool isOdd = false;
        Dictionary<char, int> dict = new();

        foreach (var c in s)
        {
            if (!dict.TryGetValue(c, out int val))
                dict.Add(c, 1);
            else
                dict[c] = val + 1;
        }


        foreach (var item in dict)
        {
            if (item.Value % 2 == 0)
                result += item.Value;
            else
            {
                var value = item.Value - 1;
                result += value;
                isOdd = true;
            }
        }

        if (isOdd)
            result++;

        return result;
    }
}
