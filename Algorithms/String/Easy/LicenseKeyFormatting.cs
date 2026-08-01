using System.Text;

namespace String.Easy;

public static class LicenseKeyFormatting
{
    public static string Run(string s, int k)
    {
        StringBuilder sb = new();
        int counter = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (counter == k)
            {
                sb.Append('-');
                counter = 0;
            }

            if (s[i] == '-')
                continue;

            sb.Append(char.ToUpper(s[i]));
            counter++;
        }


        string result = new string(sb.ToString().Reverse().ToArray());

        if (result.StartsWith("-"))
            result = result.Substring(1);

        return result;
    }
}
