/**
 * @id         3019
 * @title      Number of Changing Keys
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-changing-keys/
 */
namespace String.Easy;

public static class NumberOfChangingKeys
{
    public static int Run(string s)
    {
        s = s.ToLower();
        int changeCount = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] != s[i + 1])
                changeCount++;
        }

        return changeCount;
    }
}


