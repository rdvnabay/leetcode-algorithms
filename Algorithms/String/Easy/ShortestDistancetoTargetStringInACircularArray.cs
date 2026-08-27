/**
 * @id         2515
 * @title      Shortest Distance to Target String in a Circular Array
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/shortest-distance-to-target-string-in-a-circular-array/
 */
namespace String.Easy;

public static class ShortestDistancetoTargetStringInACircularArray
{
    //Input: words = ["hello","i","am","leetcode","hello"], target = "hello", startIndex = 1
    //Output: 1
    public static int Run(string[] words, string target, int startIndex)
    {
        if (words[startIndex] == target)
            return 0;

        //int leftStepCount = CalculateLeftStepCount(words, target, startIndex);
        //int rightStepCount = CalculateRightStepCount(words, target, startIndex);

        //return Math.Min(leftStepCount, rightStepCount);
        return 0;
    }

    static int CalculateRightStepCount(string[] words, string target, int startIndex)
    {
        int right = startIndex + 1;
        int rightStepCount = 0;

        while (right != startIndex)
        {
            rightStepCount++;

            if (right == words.Length - 1)
                right = 0;

            if (words[right] == target)
                break;

            right++;
        }

        return rightStepCount;
    }

    static int CalculateLeftStepCount(string[] words, string target, int startIndex)
    {
        int left = startIndex - 1;
        if (left == -1)
            left = words.Length - 1;

        int leftStepCount = 0;

        while (left != startIndex)
        {
            leftStepCount++;

            if (left == 0)
                left = words.Length - 1;

            if (words[left] == target)
                break;

            left--;
        }

        return leftStepCount;
    }
}
