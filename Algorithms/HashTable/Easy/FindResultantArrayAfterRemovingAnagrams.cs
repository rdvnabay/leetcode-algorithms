/**
 * @id         2273
 * @title      Find Resultant Array After Removing Anagrams
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-resultant-array-after-removing-anagrams/
 */
namespace HashTable.Easy;

public static class FindResultantArrayAfterRemovingAnagrams
{
    //"abba","baba","bbaa","cd","cd"
    //Output: ["abba","cd"]
    public static IList<string> Run(string[] words)
    {
        Dictionary<char, int> dict = new();

        foreach (var word in words)
        {
            foreach (var letter in word)
                dict[letter] = dict.GetValueOrDefault(letter, 0) + 1;
        }

        return null;
    }
}
