using Algorithms.BinarySearch.Easy.Solutions;
using BinarySearchSolution = Algorithms.BinarySearch.Easy.Solutions.BinarySearch;

namespace Algorithms.BinarySearch.Easy;

public static class BinarySearchEasyRunner
{
    public static void Run()
    {
        // 35: Search Insert Position
        SearchInsertPosition.Run(new int[] { 1, 3, 5, 6 }, 7);
        // 704: Binary Search
        BinarySearchSolution.Run(new int[] { -1, 0, 3, 5, 9, 12 }, 9);
        // 744: Find Smallest Letter Greater Than Target
        FindSmallestLetterGreaterThanTarget.Run(new char[] { 'c', 'f', 'j' }, 'c');
    }
}