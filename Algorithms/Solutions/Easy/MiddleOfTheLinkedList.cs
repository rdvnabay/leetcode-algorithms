namespace Algorithms.Solutions.Easy;

public class MiddleOfTheLinkedList
{
    public static ListNode_876 Run(ListNode_876 head)
    {
        var fast = head;

        while (fast is not null && fast.next is not null)
        {
            fast = fast.next.next;
            head = head.next;
        }

        return head;
    }
}


//Definition for singly-linked list.
public class ListNode_876
{
    public int val;
    public ListNode_876 next;
    public ListNode_876(int val = 0, ListNode_876 next = null)
    {
        this.val = val;
        this.next = next;
    }
}

