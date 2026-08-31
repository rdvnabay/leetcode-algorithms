using System.Text;

namespace String.Easy;

public static class ReverseLettersThenSpecialCharactersInAString
{
    public static string Run(string s)
    {
        List<char> lowercaseLetters = new();
        List<char> specialCharacters = new();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            char c = s[i];
            if (char.IsLetter(c))
                lowercaseLetters.Add(c);
            else
                specialCharacters.Add(c);
        }

        StringBuilder result = new();

        int letterIndex = 0;
        int specialIndex = 0;

        foreach (var c in s)
        {
            if (char.IsLetter(c))
            {
                result.Append(lowercaseLetters[letterIndex]);
                letterIndex++;
            }
            else
            {
                result.Append(specialCharacters[specialIndex]);
                specialIndex++;
            }
        }

        return result.ToString();
    }
}
