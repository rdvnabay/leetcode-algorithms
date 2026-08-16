namespace String.Easy;

public static class GreatestEnglishLetterInUpperAndLowerCase
{
    //arRAzFif
    public static string Run(string s)
    {
        HashSet<char> set = new(s);
        HashSet<char> result = new();

        foreach (var letter in s)
        {
            if (char.IsLower(letter))
            {
                if (set.Contains((char)(letter - 32)))
                    result.Add(char.ToUpper(letter));
            }
            else
            {
                if (set.Contains((char)(letter + 32)))
                    result.Add(char.ToUpper(letter));
            }
        }

        if (result.Count == 0)
            return "";

        return result.Max(x => x).ToString();
    }
}
