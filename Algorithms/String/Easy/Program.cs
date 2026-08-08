
using String.Easy;

namespace Algorithms.String.Easy;

public static class StringEasyRunner
{
    public static void Run()
    {
        LongestCommonPrefix.Run(new string[] { "c", "acc", "ccc" });
        LengthOfLastWord.Run("Hello World");
        ValidPalindrome.Run("A man, a plan, a canal: Panama");
        IsomorphicStrings.Run("badc", "baba");
        ReverseString.Run(new char[] { 'h', 'e', 'l', 'l', 'o' });
        FizzBuzz.Run(15);
        FindTheDifference.Run("abcd", "abcde");
        KeyboardRow.Run(new string[] { "Hello", "Alaska", "Dad", "Peace" });
        DetectCapital.Run("FlaG");
        RobotReturnToOrigin.Run("UDLR");
        ToLowerCase.Run("Hello");
        RemoveAllAdjacentDuplicatesInString.Run("abbaca");
        MergeStringsAlternately.Run("abc", "pqr");
        //FindTheIndexOfTheFirstOccurrenceInAString.Run("leetcode", "leeto");
        FindTheIndexOfTheFirstOccurrenceInAString.Run("mississippi", "issip");
        ExcelSheetColumnTitle.Run(701);
        ValidAnagram.Run("listen", "silent");
        WordPattern.Run("aaa", "aa aa aa aa");
        RansomNote.Run("aa", "aab");
        NumberOfSegmentsInAString.Run("Hello, my name is John");
        LicenseKeyFormatting.Run("--a-a-a-a--", 2);
        ValidPalindromeII.Run("abca");
        RotateString.Run("abcde", "cdeab");
        BuddyStrings.Run("ab", "ab");
        GreatestCommonDivisorOfStrings.Run("AAAAAB", "AAA");
        DecryptStringFromAlphabetToIntegerMapping.Run("12");
        ReverseWordsInAStringIII.Run("Let's take LeetCode contest");
        ReverseOnlyLetters.Run("Test1ng-Leet=code-Q!");
        GenerateAStringWithCharactersThatHaveOddCounts.Run(4);
        ShuffleString.Run("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 });
    }
}