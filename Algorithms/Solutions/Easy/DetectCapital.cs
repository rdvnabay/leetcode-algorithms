namespace Algorithms.Solutions.Easy;

public static class DetectCapital
{
    public static bool Run(string word)
    {
        if (word.Length == 1)
            return true;

        bool firstIsUpper = char.IsUpper(word[0]);
        bool secondIsUpper = char.IsUpper(word[1]);

        if (!firstIsUpper && secondIsUpper)
            return false;

        bool otherIsUpper = false;

        if (firstIsUpper && secondIsUpper)
            otherIsUpper = true;

        for (int i = 2; i < word.Length; i++)
        {
            if (otherIsUpper)
            {
                if (char.IsLower(word[i]))
                    return false;
            }
            else
            {
                if (char.IsUpper(word[i]))
                    return false;
            }
        }

        return true;
    }
}
