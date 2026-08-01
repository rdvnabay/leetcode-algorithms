using Algorithms.String.Easy.Solutions;

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
    }
}