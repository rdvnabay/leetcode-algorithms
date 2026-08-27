/**
 * @id         2169
 * @title      Count Operations to Obtain Zero
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-operations-to-obtain-zero/
 */
namespace Algorithms.Math.Easy;

public static class CountOperationsToObtainZero
{
    public static int Run(int num1, int num2)
    {
        int counter = 0;

        while (num1 > 0 && num2 > 0)
        {
            if (num1 >= num2)
            {
                num1 = num1 - num2;
                counter++;
            }
            else
            {
                num2 = num2 - num1;
                counter++;
            }
        }
        return counter;
    }
}


