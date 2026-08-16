namespace String.Easy;

public static class DetermineIfStringHalvesAreAlike
{
    public static bool Run(string s)
    {
        s = s.ToLower();
        HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

        int leftVowelsCount = 0;
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (vowels.Contains(s[i]))
                leftVowelsCount++;
        }

        int rightVowelsCount = 0;
        for (int i = s.Length / 2; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
                rightVowelsCount++;
        }

        return leftVowelsCount == rightVowelsCount;
    }
}
