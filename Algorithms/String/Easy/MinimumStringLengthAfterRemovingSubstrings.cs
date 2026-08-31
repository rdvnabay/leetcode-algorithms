namespace String.Easy;

public static class MinimumStringLengthAfterRemovingSubstrings
{
    public static int Run(string s)
    {
        bool isMatch = true;

        while (isMatch && s.Length > 1)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if ((s[i] == 'A' && s[i + 1] == 'B') || (s[i] == 'C' && s[i + 1] == 'D'))
                {
                    s = s.Remove(i, 2);
                    isMatch = true;
                    break;
                }
                else
                {
                    isMatch = false;
                }
            }
        }

        return s.Length;
    }
}
