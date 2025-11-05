using Algorithms.Solutions.Easy;
using Algorithms.Solutions.Medium;

//1: Two Sum (Easy)
TwoSum.Run(new int[] { 3, 2, 4 }, 6);

//3: Longest Substring Without Repeating Characters (Medium)
LongestSubstringWithoutRepeatingCharacters.Run("dvdf");

//6: Zigzag Conversion (Medium)
ZigzagConversion.Run("ABCDE", 2);

//9: Palindrome Number (Easy)
PalindromeNumber.Run(123);

//13: Roman to Integer
RomanToInteger.Run("III");

//14: Longest Common Prefix (Easy)
LongestCommonPrefix.Run(new string[] { "c", "acc", "ccc" });

//15: 3Sum
_3Sum.Run(new int[] { -1, 0, 1, 2, -1, -4 });

//17. Letter Combinations of a Phone Number
LetterCombinationsOfAPhoneNumber.Run("23");

//19: Remove Nth Node From End of List
RemoveNthNodeFromEndOfList.Run(head: new(1, new(2, new(3))), n: 3);

//20: Valid Parentheses (Easy)
ValidParentheses.Run("(){}}{");

//21: Merge Two Sorted Lists (Easy)
//MergeTwoSortedLists.Run(new DoublyListNode(2, new DoublyListNode(4, new DoublyListNode(3))), new DoublyListNode(5, new DoublyListNode(6, new DoublyListNode(4))));

//26: Remove Duplicates from Sorted Array 
RemoveDuplicatesFromSortedArray.Run(new int[] { 1, 1, 2 });

//27: Remove Element (Easy)
RemoveElement.Run(new int[] { 3, 2, 2, 3 }, 3);

//35: Search Insert Position
SearchInsertPosition.Run(new int[] { 1, 3, 5, 6 }, 7);

//58: Length of Last Word
LengthOfLastWord.Run("Hello World");

//66: Plus One (Easy)
PlusOne.Run(new int[] { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 });

//70: Climbing Stairs
ClimbingStairs.Run(4);

//118: Pascal's Triangle
PascalsTriangle.Run(5);

//121: Best Time to Buy and Sell Stock (Easy)
BestTimeToBuyAndSellStock.Run(new int[] { 3, 2, 6, 5, 0, 3 });

//125: Valid Palindrome (Easy)
ValidPalindrome.Run("A man, a plan, a canal: Panama");

//136: Single Number (Easy)
SingleNumber.Run(new int[] { -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, 354 });

//160: Intersection of Two Linked Lists

//169: Majority Element (Easy)
MajorityElement.Run(new int[] { 2, 2, 1, 1, 1, 2, 2 });

//171: Excel Sheet Column Number (Easy)
ExcelSheetColumnNumber.Run("FXSHRXW");

//191: Number of 1 Bits (Easy)
NumberOf1Bits.Run(1);

//202: Happy Number (Easy)
HappyNumber.Run(19);

//205: Isomorphic Strings
IsomorphicStrings.Run("badc", "baba");

//206: Reverse Linked List
ReverseLinkedList.Run(null);

//217: Contains Duplicate (Easy)
ContainsDuplicate.Run(new int[] { 1, 2, 3, 1 });

//225: Implement Stack using Queues (Easy)
ImplementStackUsingQueues.Run();

//226: Invert Binary Tree (Easy)
//InvertBinaryTree.Run(new(4, new(2, new(1), new(3)), new(7, new(6), new(9))));

//228: Summary Ranges
SummaryRanges.Run(new int[] { 0, 1, 2 });

//231: Power of Two
PowerOfTwo.Run(-16);

//258: Add Digits (Easy)
AddDigits.Run(3);

// 268: Missing Number (Easy)
MissingNumber.Run(new int[] { 0, 1, 3 });

//283: Move Zeroes
MoveZeroes.Run(new int[] { 0, 1, 0, 3, 12 });

//342: Power Of Four
PowerOfFour.Run(0);

//344: Reverse String (Easy)
ReverseString.Run(new char[] { 'h', 'e', 'l', 'l', 'o' });

//389. Find the Difference
FindTheDifference.Run("a", "aa");

//412: Fizz Buzz
FizzBuzz.Run(15);

//455: Assign Cookies (Easy)
//AssignCookies.Run(new int[] { 1, 2, 3 }, new int[] { 1, 1 });
AssignCookies.Run(new int[] { 10, 9, 8, 7, 10, 9, 8, 7 }, new int[] { 10, 9, 8, 7 });

//506: Relative Ranks (Easy)
RelativeRanks.Run(new int[] { 5, 4, 3, 2, 1 });

//509: Fibonacci Number (Easy)
//FibonacciNumber.Run(5);

//538: Convert BST to Greater Tree
ConvertBSTToGreaterTree.Run(new Algorithms.Solutions.Medium.TreeNode(val: 4,
    left: new(1, new(0), new(2, null, new(3))),
    right: new(6, new(5), new(7, null, new(8)))));

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

//1290: Convert Binary Number in a Linked List to Integer
ConvertBinaryNumberInALinkedListToInteger.Run(new(1, new(0, new(1, null))));

//1047: Remove All Adjacent Duplicates In String
RemoveAllAdjacentDuplicatesInString.Run("abbaca");
//Add Two Numbers (Easy)
//AddTwoNumbers.Run(new DoublyListNode(2, new DoublyListNode(4, new DoublyListNode(3))), new DoublyListNode(5, new DoublyListNode(6, new DoublyListNode(4))));

//1466: Reorder Routes to Make All Paths Lead to the City Zero (Medium)
//ReorderRoutesToMakeAllPathsLeadToTheCityZero.Run(6, new int[][] {
//new int[] { 0, 1 }, new int[] { 1, 3 },new int[]{ 2,3 },new int[]{ 4,0 },new int[]{ 4,5 } });

//3289: The Two Sneaky Numbers of Digitville (Easy)
TheTwoSneakyNumbersOfDigitville.Run(new int[] { 0, 3, 2, 1, 3, 2 });
