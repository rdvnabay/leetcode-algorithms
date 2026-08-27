/**
 * @id         2785
 * @title      Sort Vowels in a String
 * @topic      String
 * @difficulty Medium
 * @link       https://leetcode.com/problems/sort-vowels-in-a-string/
 */
namespace String.Medium;

public static class SortVowelsInAString
{
    //lEetcOde
    public static string Run(string s)
    {
        HashSet<char> vowels = new() { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
        List<char> findVowels = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                findVowels.Add(s[i]);
            }
        }

        findVowels.Sort();

        char[] result = new char[s.Length];

        int vowelIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                result[i] = findVowels[vowelIndex];
                vowelIndex++;
            }
            else
            {
                result[i] = s[i];
            }
        }

        return new string(result);
    }
}
