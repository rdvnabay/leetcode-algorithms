/**
 * @id         3884
 * @title      First Matching Character From Both Ends
 * @topic      TwoPointers
 * @difficulty Easy
 * @link       https://leetcode.com/problems/first-matching-character-from-both-ends/
 */
namespace TwoPointers.Easy;

public static class FirstMatchingCharacterFromBothEnds
{
    public static int Run(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == s[s.Length - i - 1])
                return i;
        }

        return -1;
    }
}
