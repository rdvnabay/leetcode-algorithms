using Algorithms.LinkedList.Easy;
using Algorithms.LinkedList.Medium;

Console.WriteLine("=== LinkedList Algorithms ===");

// --- Easy ------------------------------------------------------------
// ConvertBinaryNumberInALinkedListToInteger.Run(...);
MergeTwoSortedLists.Run(null, null);
MiddleOfTheLinkedList.Run(new(1, new(2, new(3, new(4, new(5, null))))));
ReverseLinkedList.Run(new(1, new(2, new(3, new(4, new(5))))));

// --- Medium ------------------------------------------------------------
// AddTwoNumbers.Run(...);
RemoveNthNodeFromEndOfList.Run(head: new Algorithms.Common.ListNode(1, new(2, new(3))), n: 3);

