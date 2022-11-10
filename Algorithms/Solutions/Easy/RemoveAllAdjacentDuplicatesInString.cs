namespace Algorithms.Solutions.Easy;

public static class RemoveAllAdjacentDuplicatesInString
{
    public static string Run(string s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            char current = s[i];
            char next = s[i + 1];

            if (current == next)
            {
                s = s.Remove(i, 2);
                i = -1;
            }
        }
        return s;
    }
}
