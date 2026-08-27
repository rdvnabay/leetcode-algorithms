/**
 * @id         3760
 * @title      Maximum Substrings With Distinct Start
 * @topic      String
 * @difficulty Medium
 * @link       https://leetcode.com/problems/maximum-substrings-with-distinct-start/
 */
namespace String.Medium;

public static class MaximumSubstringsWithDistinctStart
{
    public static int Run(string s)
    {
        return s.ToHashSet().Count;
    }
}
