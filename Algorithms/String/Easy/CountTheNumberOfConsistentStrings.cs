/**
 * @id         1684
 * @title      Count the Number of Consistent Strings
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-the-number-of-consistent-strings/
 */
namespace String.Easy;

public static class CountTheNumberOfConsistentStrings
{
    public static int Run(string allowed, string[] words)
    {
        int counter = 0;
        HashSet<char> hashSet = new(allowed);

        foreach (var word in words)
        {
            bool isConsistent = true;

            foreach (var letter in word)
            {
                if (!hashSet.Contains(letter))
                {
                    isConsistent = false;
                    break;
                }
            }

            if (isConsistent)
                counter++;
        }

        return counter;
    }
}


