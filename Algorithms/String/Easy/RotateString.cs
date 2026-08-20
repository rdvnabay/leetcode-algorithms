/**
 * @id         796
 * @title      Rotate String
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/rotate-string/
 */
namespace Algorithms.String.Easy;

public static class RotateString
{
    public static bool Run(string s, string goal)
    {
        char targetFirstChar = goal[0];
        int rotateCount = s.IndexOf(targetFirstChar);

        if (rotateCount == 0)
            return true;

        while (rotateCount > 0)
        {
            char temp = s[0];
            for (int j = 1; j < s.Length; j++)
            {
                //s[j - 1] = s[j];
            }
            //s[s.Length - 1] = temp;
            rotateCount--;
        }
        return false;
    }
}


