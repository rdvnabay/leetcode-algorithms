using Algorithms.String.Easy;
using Algorithms.String.Medium;
using String.Easy;

Console.WriteLine("=== String Algorithms ===");

// --- Easy ------------------------------------------------------------
BuddyStrings.Run("ab", "ab");
BackspaceStringCompare.Run("ab##", "c#d#");
CrawlerLogFolder.Run(new string[] { "d1/", "d2/", "../", "d21/", "./" });
DetectCapital.Run("FlaG");
ExcelSheetColumnTitle.Run(701);
FizzBuzz.Run(15);
GenerateAStringWithCharactersThatHaveOddCounts.Run(4);
GreatestCommonDivisorOfStrings.Run("AAAAAB", "AAA");
KeyboardRow.Run(new string[] { "Hello", "Alaska", "Dad", "Peace" });
LengthOfLastWord.Run("Hello World");
LicenseKeyFormatting.Run("--a-a-a-a--", 2);
LongestCommonPrefix.Run(new string[] { "c", "acc", "ccc" });
MergeStringsAlternately.Run("abc", "pqr");
PositionsOfLargeGroups.Run("abcdddeeeeaabbbcd");
RansomNote.Run("aa", "aab");
ReverseOnlyLetters.Run("Test1ng-Leet=code-Q!");
ReverseString.Run(new char[] { 'h', 'e', 'l', 'l', 'o' });
ReverseVowelsOfAString.Run("a.");
RobotReturnToOrigin.Run("UDLR");
RotateString.Run("abcde", "cdeab");
ShortestDistanceToACharacter.Run("loveleetcode", 'e');
ShuffleString.Run("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 });
StudentAttendanceRecordI.Run("PPALLL");
ToLowerCase.Run("Hello");
ValidAnagram.Run("listen", "silent");
ValidPalindrome.Run("A man, a plan, a canal: Panama");
WordPattern.Run("aaa", "aa aa aa aa");
CheckIfTwoStringArraysAreEquivalent.Run(new string[] { "abc", "d", "defg" }, new string[] { "abcddefg" });
GoalParserInterpretation.Run("(al)G(al)()()G");
CountTheNumberOfConsistentStrings.Run("cad", new string[] { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" });
ScoreOfAString.Run("hello");
FinalValueOfVariableAfterPerformingOperations.Run(new string[] { "X++", "++X", "--X", "X--" });
FindWordsContainingCharacter.Run(new string[] { "abc", "bcd", "aaaa", "cbc" }, 'a');
DefangingAnIPAddress.Run("255.100.50.0");
ReverseStringPrefix.Run("abcd", 2);
FindMostFrequentVowelAndConsonant.Run("successes");
ReverseDegreeOfAString.Run("zaza");
SplitAStringInBalancedStrings.Run("RLRRLLRLRL");
TruncateSentence.Run("Hello how are you Contestant", 4);
CountItemsMatchingARule.Run(new List<IList<string>>
{
    new List<string> { "phone", "blue", "pixel" },
    new List<string> { "computer", "silver", "lenovo" },
    new List<string> { "phone", "gold", "iphone" }
}, "type", "phone");
SortThePeople.Run(new string[] { "Mary", "John", "Emma" }, new int[] { 180, 165, 170 });
TrafficSignalColor.Run(60);

// --- Medium ------------------------------------------------------------
LongestSubstringWithoutRepeatingCharacters.Run("dvdf");
ZigzagConversion.Run("ABCDE", 2);
