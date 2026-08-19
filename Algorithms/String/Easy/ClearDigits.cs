namespace String.Easy;

public static class ClearDigits
{
    //cb34 - > ""
    //abc - > "abc"
    public static string Run(string s)
    {
        for (int i = 0; i < s.Length - 1;)
        {
            char[] result = new char[s.Length / 2];
            if (char.IsDigit(s[i + 1]))
            {
                i += 2;
            }
            else
            {
                result[i] = s[i];
                i++;
            }
        }
        return "";
    }
}
