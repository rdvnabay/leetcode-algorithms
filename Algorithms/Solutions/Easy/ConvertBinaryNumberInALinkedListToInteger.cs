namespace Algorithms.Solutions.Easy;

public class ConvertBinaryNumberInALinkedListToInteger
{
    public static int Run(Singly_ListNode head)
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
public class Singly_ListNode
{
    public int val;
    public Singly_ListNode next;
    public Singly_ListNode(int val = 0, Singly_ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

