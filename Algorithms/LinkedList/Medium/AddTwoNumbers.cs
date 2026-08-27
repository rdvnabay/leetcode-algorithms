/**
 * @id         2
 * @title      Add Two Numbers
 * @topic      LinkedList
 * @difficulty Medium
 * @link       https://leetcode.com/problems/add-two-numbers/
 */
using Algorithms.Common;
namespace Algorithms.LinkedList.Medium;

public class AddTwoNumbers
{
    public static ListNode Run(ListNode l1, ListNode l2)
    {
        var l1Total = (l1.val.ToString() + l1.next.val.ToString() + l1.next.next.val.ToString()).Reverse();
        var l2Total = (l2.val.ToString() + l2.next.val.ToString() + l2.next.next.val.ToString()).Reverse();
        return null;
    }
}





