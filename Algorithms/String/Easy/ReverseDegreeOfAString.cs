namespace String.Easy;

public static class ReverseDegreeOfAString
{
    public static int Run(string s)
    {
        int total = 0;
        const int AlphabetLength = 26;

        for (int i = 0; i < s.Length; i++)
        {
            var value = s[i] - 'a' + 1;
            int reverseValue = AlphabetLength + 1 - value;
            total += reverseValue * (i + 1);
        }

        return total;
    }
}
