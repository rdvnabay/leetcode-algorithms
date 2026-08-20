/**
 * @id         206
 * @title      Reverse Linked List
 * @topic      linked-list
 * @difficulty Easy
 * @link       https://leetcode.com/problems/reverse-linked-list/
 */
namespace Algorithms.LinkedList.Easy;

public class ReverseLinkedList
{
    public static ListNode_206 Run(ListNode_206 head)
    {
        Stack<int> stack = new();

        while (head is not null)
        {
            stack.Push(head.val);
            head = head.next;
        }

        if (stack.Count == 0)
            return null;

        var reverseList = new ListNode_206(stack.Pop());
        head = reverseList;

        while (stack.Count > 0)
        {
            head.next = new ListNode_206(stack.Pop());
            head = head.next;
        }

        return reverseList;
    }
}



//Definition for singly-linked list.
public class ListNode_206
{
    public int val;
    public ListNode_206 next;
    public ListNode_206(int val = 0, ListNode_206 next = null)
    {
        this.val = val;
        this.next = next;
    }
}


