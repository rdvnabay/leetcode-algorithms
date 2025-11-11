namespace Algorithms.Solutions.Easy;

public static class IsSubsequence
{
    public static bool Run(string s, string t)
    {
        int j = 0;
        bool isMatched = false;

        if(s.Length == 0)
            return true;

        for (int i = 0; i < s.Length; i++)
        {
            isMatched = false;
            for (; j < t.Length; j++)
            {
                if (s[i] == t[j])
                {
                    j++;
                    isMatched = true;
                    break;
                }
            }
            if (!isMatched)
                return false;
        }
        return isMatched;
    }
}
