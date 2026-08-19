namespace String.Easy;

public static class MakeTheStringGreat
{
    //abBAcC
    public static string Run(string s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (char.IsLower(s[i]))
            {
                if (s[i] == s[i + 1] + 32)
                {

                }
                else
                {

                }
            }
            else
            {
                if (s[i] == s[i + 1] - 32)
                {

                }
            }
        }
        return "";
    }
}
