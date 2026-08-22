namespace HashTable.Easy;

public static class FirstLetterToAppearTwice
{
    public static char Run(string s)
    {
        HashSet<char> set = new();
        char result = ' ';

        foreach (var letter in s)
        {
            if (!set.Add(letter))
            {
                result = letter;
                break;
            }
        }

        return result;
    }
}
