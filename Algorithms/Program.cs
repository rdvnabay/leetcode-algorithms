using Algorithms.Common;
using Algorithms.Solutions.Easy;
using Algorithms.Solutions.Medium;
using Algorithms.Sorting;

//1: Two Sum (Easy)
TwoSum.Run(new int[] { 3, 2, 4 }, 6);

//3: Longest Substring Without Repeating Characters (Medium)
LongestSubstringWithoutRepeatingCharacters.Run("dvdf");

//6: Zigzag Conversion (Medium)
ZigzagConversion.Run("ABCDE", 2);

//7: Reverse Integer (Medium)
ReverseInteger.Run(1534236469); 

//9: Palindrome Number (Easy)
PalindromeNumber.Run(123);

//13: Roman to Integer (Easy)
RomanToInteger.Run("III");

//14: Longest Common Prefix (Easy)
LongestCommonPrefix.Run(new string[] { "c", "acc", "ccc" });

//19: Remove Nth Node From End of List (Medium)
RemoveNthNodeFromEndOfList.Run(head: new(1, new(2, new(3))), n: 3);

//20: Valid Parentheses (Easy)
ValidParentheses.Run("(){}}{");

//35: Search Insert Position (Easy)
SearchInsertPosition.Run(new int[] { 1, 3, 5, 6 }, 7);

//58: Length of Last Word (Easy)
LengthOfLastWord.Run("Hello World");

//66: Plus One (Easy)
PlusOne.Run(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 });

//70: Climbing Stairs (Easy)
ClimbingStairs.Run(4);

//118: Pascal's Triangle (Easy)
PascalsTriangle.Run(5);

//121: Best Time to Buy and Sell Stock (Easy)
BestTimeToBuyAndSellStock.Run(new int[] { 3, 2, 6, 5, 0, 3 });

//125: Valid Palindrome (Easy)
ValidPalindrome.Run("A man, a plan, a canal: Panama");

//136: Single Number (Easy)
SingleNumber.Run(new int[] { -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, 354 });

//169: Majority Element (Easy)
MajorityElement.Run(new int[] { 2, 2, 1, 1, 1, 2, 2 });

//191: Number of 1 Bits (Easy)
NumberOf1Bits.Run(1);

//202: Happy Number (Easy)
HappyNumber.Run(19);

//205: Isomorphic Strings (Easy)
IsomorphicStrings.Run("badc", "baba");

//206: Reverse Linked List (Easy)
ReverseLinkedList.Run(new(1, new(2, new(3, new(4, new(5))))));

//217: Contains Duplicate (Easy)
ContainsDuplicate.Run(new int[] { 1, 2, 3, 1 });

//225: Implement Stack using Queues (Easy)
ImplementStackUsingQueues.Run();

//228: Summary Ranges (Easy)
SummaryRanges.Run(new int[] { 0, 1, 2 });

//231: Power of Two (Easy)
PowerOfTwo.Run(-16);

//238: Product of Array Except Self (Medium)
ProductOfArrayExceptSelf.Run(new int[] { -1, 1, 0, -3, 3 });

//258: Add Digits (Easy)
AddDigits.Run(3);

// 268: Missing Number (Easy)
MissingNumber.Run(new int[] { 0, 1, 3 });

//334: Increasing Triplet Subsequence (Medium)
IncreasingTripletSubsequence.Run(new int[] { 2, 1, 5, 0, 4, 6 });

//342: Power Of Four (Easy)
PowerOfFour.Run(0);

//344: Reverse String (Easy)
ReverseString.Run(new char[] { 'h', 'e', 'l', 'l', 'o' });

//392: Is Subsequence (Easy)
IsSubsequence.Run("abc", "ahbgdc");

//412: Fizz Buzz (Easy)
FizzBuzz.Run(15);

//441: Arranging Coins (Easy)
ArrangingCoins.Run(6);

//455: Assign Cookies (Easy)
//AssignCookies.Run(new int[] { 1, 2, 3 }, new int[] { 1, 1 });
AssignCookies.Run(new int[] { 10, 9, 8, 7, 10, 9, 8, 7 }, new int[] { 10, 9, 8, 7 });

//485: Max Consecutive Ones (Easy)
MaxConsecutiveOnes.Run(new int[] { 1, 1, 0, 1, 1, 1 });

//506: Relative Ranks (Easy)
RelativeRanks.Run(new int[] { 5, 4, 3, 2, 1 });

//509: Fibonacci Number (Easy)
//FibonacciNumber.Run(5);

//520: Detect Capital (Easy)
DetectCapital.Run("FlaG");

//538: Convert BST to Greater Tree
ConvertBSTToGreaterTree.Run(new Algorithms.Solutions.Medium.TreeNode(val: 4,
    left: new(1, new(0), new(2, null, new(3))),
    right: new(6, new(5), new(7, null, new(8)))));

//605: Can Place Flowers (Easy)
CanPlaceFlowers.Run(new int[] { 1, 0 }, 1);

//657: Robot Return to Origin (Easy)
RobotReturnToOrigin.Run("UDLR");

//682: Baseball Game (Easy)
BaseballGame.Run(new string[] { "5", "2", "C", "D", "+" });

//709: To Lower Case (Easy)
ToLowerCase.Run("Hello");

//728: Self Dividing Numbers (Easy)
SelfDividingNumbers.Run(1, 22);

//739: Daily Temperatures (Medium)
//DailyTemperatures.Run(new int[] { 34, 80, 80, 34, 34, 80, 80, 80, 80, 34 });

//771: Jewels and Stones (Easy)
JewelsAndStones.Run("aA", "aAAbbbb");

//876: Middle of the Linked List
MiddleOfTheLinkedList.Run(new(1, new(2, new(3, new(4, new(5, null))))));

//1018: Binary Prefix Divisible By 5
BinaryPrefixDivisibleBy5.Run(new int[] { 1, 1, 1 });

//1047: Remove All Adjacent Duplicates In String
RemoveAllAdjacentDuplicatesInString.Run("abbaca");
//Add Two Numbers (Easy)
//AddTwoNumbers.Run(new DoublyListNode(2, new DoublyListNode(4, new DoublyListNode(3))), new DoublyListNode(5, new DoublyListNode(6, new DoublyListNode(4))));

//1290: Convert Binary Number in a Linked List to Integer
ConvertBinaryNumberInALinkedListToInteger.Run(new(1, new(0, new(1, null))));

//1431: Kids With the Greatest Number of Candies (Easy)
KidsWithTheGreatestNumberOfCandies.Run(new int[] { 2, 3, 5, 1, 3 }, 3);

//1768: Merge Strings Alternately (Easy)
MergeStringsAlternately.Run("abc", "pqr");

//3289: The Two Sneaky Numbers of Digitville (Easy)
TheTwoSneakyNumbersOfDigitville.Run(new int[] { 0, 3, 2, 1, 3, 2 });


SelectionSort.Run();