using Algorithms.Common;
using Algorithms.Solutions;
using Algorithms.Solutions.Easy;
using Algorithms.Solutions.Medium;

//1: Two Sum (Easy)
TwoSum.Run(new int[] { 3, 2, 4 }, 6);

//9: Palindrome Number (Easy)
PalindromeNumber.Run(123);

//13: Roman to Integer
//RomanToInteger.Run("MCMXCIV");

//14: Longest Common Prefix (Easy)
LongestCommonPrefix.Run(new string[] { "c", "acc", "ccc" });

//19: Remove Nth Node From End of List
RemoveNthNodeFromEndOfList.Run(head: new(1, new(2,new(3))), n: 3);

//20: Valid Parentheses (Easy)
ValidParentheses.Run("(){}}{");

//21: Merge Two Sorted Lists (Easy)
MergeTwoSortedLists.Run(new DoublyListNode(2, new DoublyListNode(4, new DoublyListNode(3))), new DoublyListNode(5, new DoublyListNode(6, new DoublyListNode(4))));

//26: Remove Duplicates from Sorted Array 
RemoveDuplicatesFromSortedArray.Run(new int[] { 1, 1, 2 });

//136: Single Number (Easy)
SingleNumber.Run(new int[] { -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, -336, 513, -560, -481, -174, 101, -997, 40, -527, -784, -283, 354 });

//169: Majority Element (Easy)
MajorityElement.Run(new int[] { 2, 2, 1, 1, 1, 2, 2 });

//217: Contains Duplicate (Easy)
ContainsDuplicate.Run(new int[] { 1, 2, 3, 1 });

//225: Implement Stack using Queues (Easy)
ImplementStackUsingQueues.Run();

//682: Baseball Game (Easy)
BaseballGame.Run(new string[] { "5", "2", "C", "D", "+" });

//739: Daily Temperatures (Medium)
DailyTemperatures.Run(new int[] { 34, 80, 80, 34, 34, 80, 80, 80, 80, 34 });

//Add Two Numbers (Easy)
AddTwoNumbers.Run(new DoublyListNode(2, new DoublyListNode(4, new DoublyListNode(3))), new DoublyListNode(5, new DoublyListNode(6, new DoublyListNode(4))));