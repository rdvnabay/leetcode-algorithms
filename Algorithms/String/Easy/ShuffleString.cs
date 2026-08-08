namespace String.Easy;

public static class ShuffleString
{
    public static string Run(string s, int[] indices)
    {
        char[] charArray = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
            charArray[indices[i]] = s[i];

        return new string(charArray);
    }
}
