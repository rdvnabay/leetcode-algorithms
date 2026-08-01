namespace Algorithms.String.Easy;

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

        var origin = System.String.Concat(onlyTextualExpressions).ToLower();
        var reverse = System.String.Concat(origin.Reverse());

        return origin == reverse ? true : false;
    }
}
