namespace String.Easy;

public static class SubstringsOfSizeThreeWithDistinctCharacters
{
    public static int Run(string s)
    {
        int counter = 0;

        for (int i = 0; i < s.Length - 2; i++)
        {
            char first = s[i];
            char mid = s[i + 1];
            char last = s[i + 2];

            if (!(first == mid || first == last || mid == last))
                counter++;
        }

        return counter;
    }
}
