using Algorithms.Common;
namespace Algorithms.Solutions;

public class AddTwoNumbers
{
    public static ListNode Run(ListNode l1, ListNode l2)
    {
        var l1Total = (l1.val.ToString() + l1.next.val.ToString() + l1.next.next.val.ToString()).Reverse();
        var l2Total = (l2.val.ToString() + l2.next.val.ToString() + l2.next.next.val.ToString()).Reverse();
        return null;
    }
}



