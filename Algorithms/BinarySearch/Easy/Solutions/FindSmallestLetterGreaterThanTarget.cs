namespace Algorithms.BinarySearch.Easy.Solutions;

public class FindSmallestLetterGreaterThanTarget
{
    public static char Run(char[] letters, char target)
    {
        char firstLetter = letters[0];

        foreach (var letter in letters)
        {
            if (letter > target)
                return letter;
        }
        return firstLetter;
    }
}
