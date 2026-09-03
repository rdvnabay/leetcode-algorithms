/**
 * @id         1641
 * @title      Count Sorted Vowel Strings
 * @topic      DynamicProgramming
 * @difficulty Medium
 * @link       https://leetcode.com/problems/count-sorted-vowel-strings/
 */
namespace DynamicProgramming.Medium;

public static class CountSortedVowelStrings
{
    public static int Run(int n)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        int total = 0;

        for (int i = 1; i <= vowels.Length; i++)
            total += (int)Math.Pow(i, n - 1);

        return total;
    }
}
