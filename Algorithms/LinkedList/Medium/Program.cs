using Algorithms.LinkedList.Medium.Solutions;
using Algorithms.Common;

namespace Algorithms.LinkedList.Medium;

public static class LinkedListMediumRunner
{
    public static void Run()
    {
        // 2: Add Two Numbers (stub)
        // AddTwoNumbers.Run(...);
        // 19: Remove Nth Node From End of List
        RemoveNthNodeFromEndOfList.Run(head: new Algorithms.Common.ListNode(1, new(2, new(3))), n: 3);
    }
}