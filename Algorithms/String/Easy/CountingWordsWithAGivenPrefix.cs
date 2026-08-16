namespace String.Easy;

public static class CountingWordsWithAGivenPrefix
{
    public static int Run(string[] words, string pref)
    {
        int result = 0;

        for (int i = 0; i < words.Length; i++)
        {
            int counter = pref.Length;

            for (int j = 0; j < words[i].Length; j++)
            {
                if (words[i][j] == pref[j])
                    counter--;
                else
                    break;

                if (counter == 0)
                {
                    result++;
                    break;
                }
            }
        }

        return result;
    }
}
