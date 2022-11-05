namespace Algorithms.Solutions.Easy;

public static class ValidPalindrome
{
    public static bool Run(string s)
    {
        List<char> onlyTextualExpressions = new();

        foreach (char character in s)
        {
            if (char.IsLetterOrDigit(character))
                onlyTextualExpressions.Add(character);
        }

        var origin = String.Concat(onlyTextualExpressions).ToLower();
        var reverse = String.Concat(origin.Reverse());

        return origin == reverse ? true : false;
    }
}
