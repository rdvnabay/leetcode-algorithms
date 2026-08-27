/**
 * @id         744
 * @title      Find Smallest Letter Greater Than Target
 * @topic      BinarySearch
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-smallest-letter-greater-than-target/
 */
namespace Algorithms.BinarySearch.Easy;

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


