using Algorithms.String.Easy.Solutions;

namespace Algorithms.String.Easy;

public static class StringEasyRunner
{
    public static void Run()
    {
        // 14: Longest Common Prefix
        LongestCommonPrefix.Run(new string[] { "c", "acc", "ccc" });
        // 58: Length of Last Word
        LengthOfLastWord.Run("Hello World");
        // 125: Valid Palindrome
        ValidPalindrome.Run("A man, a plan, a canal: Panama");
        // 205: Isomorphic Strings
        IsomorphicStrings.Run("badc", "baba");
        // 344: Reverse String
        ReverseString.Run(new char[] { 'h', 'e', 'l', 'l', 'o' });
        // 412: Fizz Buzz
        FizzBuzz.Run(15);
        // 389: Find the Difference
        FindTheDifference.Run("abcd", "abcde");
        // 500: Keyboard Row
        KeyboardRow.Run(new string[] { "Hello", "Alaska", "Dad", "Peace" });
        // 520: Detect Capital
        DetectCapital.Run("FlaG");
        // 657: Robot Return to Origin
        RobotReturnToOrigin.Run("UDLR");
        // 709: To Lower Case
        ToLowerCase.Run("Hello");
        // 1047: Remove All Adjacent Duplicates In String
        RemoveAllAdjacentDuplicatesInString.Run("abbaca");
        // 1768: Merge Strings Alternately
        MergeStringsAlternately.Run("abc", "pqr");
    }
}