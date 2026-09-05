namespace HashTable.Easy;

public static class CountVowelSubstringsOfAString
{
    public static int Run(string word)
    {
        int counter = 0;
        HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

        for (int i = 0; i < word.Length; i++)
        {
            HashSet<char> result = new();

            if (!vowels.Contains(word[i]))
                continue;
            else
                result.Add(word[i]);

            for (int j = i + 1; j < word.Length; j++)
            {
                if (vowels.Contains(word[j]))
                {
                    result.Add(word[j]);
                    if (result.Count == vowels.Count)
                        counter++;
                }
                else
                {
                    break;
                }
            }
        }

        return counter;
    }
}
