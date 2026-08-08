using System.Collections;

namespace Algorithms.String.Easy;

public static class BuddyStrings
{
    public static bool Run(string s, string goal)
    {
        if (s.Length != goal.Length)
            return false;

        if (s == goal)
            return true;

        int counter = 0;


        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == goal[i])
                counter++;
        }

        return s.Length - counter == 2;
    }
}
