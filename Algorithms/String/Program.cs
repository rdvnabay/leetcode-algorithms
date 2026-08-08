using Algorithms.String.Easy;
using Algorithms.String.Medium;

Console.WriteLine("=== String Algorithms ===");

// --- Easy ------------------------------------------------------------
BuddyStrings.Run("ab", "ab");
CrawlerLogFolder.Run(new string[] { "d1/", "d2/", "../", "d21/", "./" });
// DecryptStringFromAlphabetToIntegerMapping.Run(...);
DetectCapital.Run("FlaG");
ExcelSheetColumnTitle.Run(701);
FindTheDifference.Run("abcd", "abcde");
// FindTheIndexOfTheFirstOccurrenceInAString.Run(...);
FizzBuzz.Run(15);
GenerateAStringWithCharactersThatHaveOddCounts.Run(4);
GreatestCommonDivisorOfStrings.Run("AAAAAB", "AAA");
// IsomorphicStrings.Run(...);
KeyboardRow.Run(new string[] { "Hello", "Alaska", "Dad", "Peace" });
LengthOfLastWord.Run("Hello World");
LicenseKeyFormatting.Run("--a-a-a-a--", 2);
LongestCommonPrefix.Run(new string[] { "c", "acc", "ccc" });
MergeStringsAlternately.Run("abc", "pqr");
// NumberOfSegmentsInAString.Run(...);
RansomNote.Run("aa", "aab");
// RemoveAllAdjacentDuplicatesInString.Run(...);
ReverseOnlyLetters.Run("Test1ng-Leet=code-Q!");
ReverseString.Run(new char[] { 'h', 'e', 'l', 'l', 'o' });
ReverseVowelsOfAString.Run("a.");
// ReverseWordsInAStringIII.Run(...);
RobotReturnToOrigin.Run("UDLR");
RotateString.Run("abcde", "cdeab");
ShuffleString.Run("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 });
ToLowerCase.Run("Hello");
ValidAnagram.Run("listen", "silent");
ValidPalindrome.Run("A man, a plan, a canal: Panama");
// ValidPalindromeII.Run(...);
WordPattern.Run("aaa", "aa aa aa aa");

// --- Medium ------------------------------------------------------------
LongestSubstringWithoutRepeatingCharacters.Run("dvdf");
ZigzagConversion.Run("ABCDE", 2);

