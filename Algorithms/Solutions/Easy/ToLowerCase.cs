namespace Algorithms.Solutions.Easy;

public static class ToLowerCase
{
    public static string Run(string s)
    {
        char[] characters = s.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsUpper(characters[i]))
                characters[i] = char.ToLower(characters[i]);
        }

        var result = new string(characters);
        return result;

    }
}
