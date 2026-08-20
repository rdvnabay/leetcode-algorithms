/**
 * @id         19
 * @title      Remove Nth Node From End of List
 * @topic      linked-list
 * @difficulty Medium
 * @link       https://leetcode.com/problems/remove-nth-node-from-end-of-list/
 */
using Algorithms.Common;
namespace Algorithms.LinkedList.Medium;

public class RemoveNthNodeFromEndOfList
{
    // Runtime: 113 ms, faster than 65.80% of C# online submissions for Remove Nth Node From End of List.
    // Memory Usage: 38.2 MB, less than 17.76% of C# online submissions for Remove Nth Node From End of List.
    public static ListNode Run(ListNode head, int n)
    {
        var leftPointer = head;
        var rightPointer = head;

        if (head.next is null)
            return head.next;

        while (n != 0)
        {
            if (rightPointer.next == null)
                break;

            rightPointer = rightPointer.next;
            n--;
        }

        while (rightPointer.next != null)
        {
            leftPointer = leftPointer.next;
            rightPointer = rightPointer.next;
        }

        if (n > 0)
            head = leftPointer.next;
        else
            leftPointer.next = leftPointer.next.next;

        return head;
    }
}



