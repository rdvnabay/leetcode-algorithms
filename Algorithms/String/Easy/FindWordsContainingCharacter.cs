namespace String.Easy;

public static class FindWordsContainingCharacter
{
    public static IList<int> Run(string[] words, char x)
    {
        List<int> result = new();

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                if (words[i][j] == x)
                {
                    result.Add(i);
                    break;
                }
            }
        }

        return result;
    }
}
