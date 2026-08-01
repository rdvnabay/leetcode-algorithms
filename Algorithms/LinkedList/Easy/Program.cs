
namespace Algorithms.LinkedList.Easy;

public static class LinkedListEasyRunner
{
    public static void Run()
    {
        // 21: Merge Two Sorted Lists
        MergeTwoSortedLists.Run(null, null);
        // 206: Reverse Linked List
        ReverseLinkedList.Run(new(1, new(2, new(3, new(4, new(5))))));
        // 876: Middle of the Linked List
        MiddleOfTheLinkedList.Run(new(1, new(2, new(3, new(4, new(5, null))))));
        // 1290: Convert Binary Number in a Linked List to Integer
        ConvertBinaryNumberInALinkedListToInteger.Run(new(1, new(0, new(1, null))));
    }
}