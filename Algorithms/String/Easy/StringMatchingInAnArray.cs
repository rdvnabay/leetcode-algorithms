namespace String.Easy;

public static class StringMatchingInAnArray
{
    //"mass","as","hero","superhero"
    public static IList<string> Run(string[] words)
    {
        HashSet<string> result = new();

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (i == j)
                    continue;

                if (words[i].Length >= words[j].Length)
                    continue;
            }
        }
        return null;
    }
}
