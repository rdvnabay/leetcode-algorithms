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
