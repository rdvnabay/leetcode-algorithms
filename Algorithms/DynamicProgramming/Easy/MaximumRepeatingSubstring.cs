/**
 * @id         1668
 * @title      Maximum Repeating Substring
 * @topic      DynamicProgramming
 * @difficulty Easy
 * @link       https://leetcode.com/problems/maximum-repeating-substring/
 */
namespace DynamicProgramming.Easy;

public static class MaximumRepeatingSubstring
{
    //ababc  ab
    public static int Run(string sequence, string word)
    {
        int j = 0;
        int counter = 0;
        int result = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            if (i != 0 && i % word.Length == 0)
            {
                if (counter == word.Length)
                    result++;

                counter = 0;
                j = 0;
            }

            if (sequence[i] == word[j])
            {
                j++;
                counter++;
            }
            else
            {
                j = 0;
            }

        }

        return result;
    }
}
