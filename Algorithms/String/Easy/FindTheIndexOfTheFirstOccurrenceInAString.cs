/**
 * @id         28
 * @title      Find the Index of the First Occurrence in a String
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
 */
using System.Reflection;

namespace Algorithms.String.Easy;

public static class FindTheIndexOfTheFirstOccurrenceInAString
{
    public static int Run(string haystack, string needle)
    {
        int matchCount = 0;
        int counter = 0;

        for (int i = 0; i < needle.Length; i++)
        {
            int lenght = haystack.Length - needle.Length + i;

            for (int j = counter; j <= lenght; j++)
            {
                counter++;

                var a = needle[i];
                var b = haystack[j];

                if (haystack[j] == needle[i])
                {
                    matchCount++;

                    if (matchCount == needle.Length)
                    {
                        int firstIndex = j - needle.Length + 1;
                        return firstIndex;
                    }
                }
                else
                {
                    i = needle.LastIndexOf(needle[0], matchCount) - 1;


                    if (haystack.Length - counter < needle.Length)
                        return -1;
                }
                break;
            }
        }
        return -1;
    }
}


