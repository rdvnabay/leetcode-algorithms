namespace String.Easy;

public static class CheckIfAWordOccursAsAPrefixOfAnyWordInASentence
{
    //"i love eating burger", "burg"
    public static int Run(string sentence, string searchWord)
    {
        bool isMatch = false;
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                if (searchWord.Length - 1 >= j)
                {
                    if (words[i][j] != searchWord[j])
                        break;

                    isMatch = true;
                }
            }

            if (isMatch)
                return i + 1;
        }

        return -1;
    }
}
