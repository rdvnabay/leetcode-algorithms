namespace String.Easy;

public static class CheckIfNumbersAreAscendingInASentence
{
    //1 box has 3 blue 4 red 6 green and 12 yellow marbles
    public static bool Run(string s)
    {
        string[] words = s.Split(' ');
        int number = 0;

        foreach (var word in words)
        {
            if (char.IsDigit(word[0]))
            {
                int value = int.Parse(word);
                if (value > number)
                    number = value;
                else
                    return false;
            }
        }

        return true;
    }
}
