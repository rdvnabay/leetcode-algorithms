namespace String.Easy;

public static class NumberOfChangingKeys
{
    public static int Run(string s)
    {
        s = s.ToLower();
        int changeCount = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] != s[i + 1])
                changeCount++;
        }

        return changeCount;
    }
}
