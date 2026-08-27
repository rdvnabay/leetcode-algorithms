namespace String.Easy;

public static class MaximumNumberOfBalloons
{
    public static int Run(string text)
    {
        Dictionary<char, int> dict = new();

        foreach (var letter in text)
            dict[letter] = dict.GetValueOrDefault(letter, 0) + 1;

        //balloon
        //loonbalxballpoon

        return 0;
    }
}
