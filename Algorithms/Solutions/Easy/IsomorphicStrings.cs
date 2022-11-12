namespace Algorithms.Solutions.Easy;

public static class IsomorphicStrings
{
    public static bool Run(string s, string t)
    {
        Dictionary<char, char> characters = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (characters.Any(c => c.Key == s[i]))
            {
                characters.TryGetValue(s[i], out char previousValue);
                if (t[i] != previousValue) return false;
            }
            else if (characters.Any(c => c.Value == t[i]))
            {
                var currentChar = characters.Where(c => c.Value == t[i]).First();
                if (currentChar.Key != s[i]) return false;
            }
            else
                characters.Add(s[i], t[i]);
        }

        return true;
    }
}
