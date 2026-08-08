namespace Algorithms.String.Easy;

public class GenerateAStringWithCharactersThatHaveOddCounts
{
    public static string Run(int n)
    {
        char[] charArray = new char[n];

        for (int i = 0; i < charArray.Length; i++)
            charArray[i] = 'a';

        if (n % 2 == 0)
            charArray[charArray.Length - 1] = 'b';

        return new string(charArray);
    }
}
