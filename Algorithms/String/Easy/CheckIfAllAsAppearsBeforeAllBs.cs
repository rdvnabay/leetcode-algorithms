/**
 * @id         2124
 * @title      Check if All A's Appears Before All B's
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/check-if-all-as-appears-before-all-bs/
 */
namespace String.Easy;

public static class CheckIfAllAsAppearsBeforeAllBs
{
    public static bool Run(string s)
    {
        for (int i = 0; i < s.Length-1; i++)
        {
            if (s[i] == 'b' && s[i + 1] == 'a')
                return false;
        }

        return true;
    }
}
