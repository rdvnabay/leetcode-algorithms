namespace String.Easy;

public static class CountTheNumberOfSpecialCharactersI
{
    public static int Run(string word)
    {
        HashSet<char> letters = new(word);
        int counter = 0;

        foreach (var letter in letters)
        {
            if (letters.Contains((char)(letter - 32)) || letters.Contains((char)(letter + 32)))
                counter++;
        }

        return counter / 2;
    }
}
