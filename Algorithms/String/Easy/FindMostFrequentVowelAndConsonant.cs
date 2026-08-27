/**
 * @id         3541
 * @title      Find Most Frequent Vowel and Consonant
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-most-frequent-vowel-and-consonant/
 */
namespace String.Easy;

public static class FindMostFrequentVowelAndConsonant
{
    //successes
    public static int Run(string s)
    {
        Dictionary<char, int> vowels = new();
        Dictionary<char, int> consonants = new();
        HashSet<char> hashSet = new() { 'a', 'e', 'i', 'o', 'u' };

        foreach (var letter in s)
        {
            if (hashSet.Contains(letter))
            {
                if (!vowels.TryGetValue(letter, out int count))
                    vowels[letter] = 1;
                else
                    vowels[letter] = count + 1;
            }
            else
            {
                if (!consonants.TryGetValue(letter, out int count))
                    consonants[letter] = 1;
                else
                    consonants[letter] = count + 1;
            }
        }

        int maxVowelCount = 0;
        foreach (var vowel in vowels)
        {
            if (vowel.Value > maxVowelCount)
                maxVowelCount = vowel.Value;
        }

        int maxConsonantCount = 0;
        foreach (var consonant in consonants)
        {
            if (consonant.Value > maxConsonantCount)
                maxConsonantCount = consonant.Value;
        }

        return maxVowelCount + maxConsonantCount;
    }
}


