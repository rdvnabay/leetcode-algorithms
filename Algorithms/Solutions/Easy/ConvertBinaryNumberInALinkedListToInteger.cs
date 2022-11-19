namespace Algorithms.Solutions.Easy;

public class ConvertBinaryNumberInALinkedListToInteger
{
    public static int Run(ListNode_1290 head)
    {
        string result = string.Empty;

        while (head is not null)
        {
            result += head.val;
            head = head.next;
        }

        return Convert.ToInt32(result, 2);
    }
}



// Definition for singly-linked list.
public class ListNode_1290
{
    public int val;
    public ListNode_1290 next;
    public ListNode_1290(int val = 0, ListNode_1290 next = null)
    {
        this.val = val;
        this.next = next;
    }
}

