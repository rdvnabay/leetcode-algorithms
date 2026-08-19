using System.Text;

namespace Math.Easy;

public static class CheckIfDigitsAreEqualInStringAfterOperationsI
{
    public static bool Run(string s)
    {
        StringBuilder sb = new(s);

        while (sb.Length > 2)
        {
            s = sb.ToString();
            sb.Clear();

            for (int i = 0; i < s.Length - 1; i++)
            {
                int left = s[i] - '0';
                int right = s[i + 1] - '0';
                sb.Append((left + right) % 10);
            }
        }

        return sb[0] == sb[1];
    }
}
