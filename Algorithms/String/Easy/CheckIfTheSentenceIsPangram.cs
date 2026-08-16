namespace String.Easy;

public static class CheckIfTheSentenceIsPangram
{
    public static bool Run(string sentence)
    {
        HashSet<char> alphabet = new(sentence);
        return alphabet.Count == 26;
    }
}
