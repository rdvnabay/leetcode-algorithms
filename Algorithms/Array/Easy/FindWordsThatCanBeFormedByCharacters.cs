namespace Array.Easy;

public static class FindWordsThatCanBeFormedByCharacters
{
    public static int Run(string[] words, string chars)
    {
        Dictionary<char, int> dict = new();
        int totalMatchCharCount = 0;

        foreach (var c in chars)
            dict[c] = dict.GetValueOrDefault(c, 0) + 1;


        foreach (var word in words)
        {
            bool isMatch = true;
            Dictionary<char, int> currentWord = new();

            foreach (var letter in word)
            {
                if (!dict.ContainsKey(letter))
                {
                    isMatch = false;
                    break;
                }

                currentWord[letter] = currentWord.GetValueOrDefault(letter, 0) + 1;
                if (dict[letter] < currentWord[letter])
                {
                    isMatch = false;
                    break;
                }
            }

            if (isMatch)
                totalMatchCharCount += word.Length;
        }

        return totalMatchCharCount;
    }



}
