namespace String.Easy;

public static class ReplaceAllDigitsWithCharacters
{
    public static string Run(string s)
    {
        char[] result = new char[s.Length];

        for (int i = 0; i < s.Length; i += 2)
        {
            result[i] = s[i];

            if (i + 1 < s.Length)
            {
                int shift = s[i + 1] - '0';
                result[i + 1] = (char)(s[i] + shift);
            }
        }

        return new string(result);
    }
}
