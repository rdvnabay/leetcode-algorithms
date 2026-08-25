namespace String.Easy;

public static class FindTheOriginalTypedStringI
{
    public static int Run(string word)
    {
        int total = 1;
       
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (word[i] == word[i + 1])
                total++;
        }

        return total;
    }
}
