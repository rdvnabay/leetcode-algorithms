// Demo runner for 6 indexed solution files. Canonical ordering: LeetCode problem ID.
using Algorithms.LinkedList.Easy;
using Algorithms.LinkedList.Medium;

Console.WriteLine("=== LinkedList Algorithms ===");

// --- Easy ------------------------------------------------------------
MergeTwoSortedLists.Run(null, null);
MiddleOfTheLinkedList.Run(new(1, new(2, new(3, new(4, new(5, null))))));
ReverseLinkedList.Run(new(1, new(2, new(3, new(4, new(5))))));

// --- Medium ------------------------------------------------------------
RemoveNthNodeFromEndOfList.Run(head: new Algorithms.Common.ListNode(1, new(2, new(3))), n: 3);


