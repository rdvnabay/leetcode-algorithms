using Algorithms.Common;
using Algorithms.Solutions;
using Algorithms.Solutions.Easy;
using Algorithms.Solutions.Medium;

//1: Two Sum (Easy)
TwoSum.Run(new int[] { 3, 2, 4 }, 6);

//9: Palindrome Number (Easy)
PalindromeNumber.Run(123);

//13: Roman to Integer
RomanToInteger.Run("III");

//14: Longest Common Prefix (Easy)
LongestCommonPrefix.Run(new string[] { "c", "acc", "ccc" });

//19: Remove Nth Node From End of List
RemoveNthNodeFromEndOfList.Run(head: new(1, new(2, new(3))), n: 3);

//20: Valid Parentheses (Easy)
ValidParentheses.Run("(){}}{");

//21: Merge Two Sorted Lists (Easy)
MergeTwoSortedLists.Run(new DoublyListNode(2, new DoublyListNode(4, new DoublyListNode(3))), new DoublyListNode(5, new DoublyListNode(6, new DoublyListNode(4))));

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
ClimbingStairs.Run(3);

//121: Best Time to Buy and Sell Stock (Easy)
BestTimeToBuyAndSellStock.Run(new int[] { 3, 2, 6, 5, 0, 3 });

//136: Single Number (Easy)
SingleNumber.Run(new int[] { -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, 354 });

//160: Intersection of Two Linked Lists

//169: Majority Element (Easy)
MajorityElement.Run(new int[] { 2, 2, 1, 1, 1, 2, 2 });

//202: Happy Number (Easy)
HappyNumber.Run(19);

//217: Contains Duplicate (Easy)
ContainsDuplicate.Run(new int[] { 1, 2, 3, 1 });

//225: Implement Stack using Queues (Easy)
ImplementStackUsingQueues.Run();

//226: Invert Binary Tree (Easy)
InvertBinaryTree.Run(new(4, new(2, new(1), new(3)), new(7, new(6), new(9))));

//344: Reverse String (Easy)
ReverseString.Run(new char[] { 'h', 'e', 'l', 'l', 'o' });

//509: Fibonacci Number (Easy)
FibonacciNumber.Run(5);

//538: Convert BST to Greater Tree
ConvertBSTToGreaterTree.Run(new Algorithms.Solutions.Medium.TreeNode(val: 4,
    left: new(1, new(0), new(2, null, new(3))),
    right: new(6, new(5), new(7, null, new(8)))));

//682: Baseball Game (Easy)
BaseballGame.Run(new string[] { "5", "2", "C", "D", "+" });

//739: Daily Temperatures (Medium)
DailyTemperatures.Run(new int[] { 34, 80, 80, 34, 34, 80, 80, 80, 80, 34 });

//Add Two Numbers (Easy)
AddTwoNumbers.Run(new DoublyListNode(2, new DoublyListNode(4, new DoublyListNode(3))), new DoublyListNode(5, new DoublyListNode(6, new DoublyListNode(4))));

//1466: Reorder Routes to Make All Paths Lead to the City Zero (Medium)
ReorderRoutesToMakeAllPathsLeadToTheCityZero.Run(6, new int[][] {
    new int[] { 0, 1 }, new int[] { 1, 3 },new int[]{ 2,3 },new int[]{ 4,0 },new int[]{ 4,5 } });