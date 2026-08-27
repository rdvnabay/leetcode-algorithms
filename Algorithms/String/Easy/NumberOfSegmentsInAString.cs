/**
 * @id         434
 * @title      Number of Segments in a String
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-segments-in-a-string/
 */
namespace Algorithms.String.Easy;

public static class NumberOfSegmentsInAString
{
    public static int Run(string s)
    {
        return s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}


