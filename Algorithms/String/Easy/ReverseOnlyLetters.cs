namespace Algorithms.String.Easy;

public static class ReverseOnlyLetters
{
    public static string Run(string s)
    {
        char[] reversed = new char[s.Length];

        int left = 0;
        int right = s.Length - 1;

        while (left <= right)
        {
            if (char.IsLetter(s[left]) && char.IsLetter(s[right]))
            {
                reversed[right] = s[left];
                reversed[left] = s[right];
                left++;
                right--;
            }

            else if (!char.IsLetter(s[left]))
            {
                reversed[left] = s[left];
                left++;
            }

            else if (!char.IsLetter(s[right]))
            {
                reversed[right] = s[right];
                right--;
            }
        }

        return new string(reversed);
    }
}