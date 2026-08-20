/**
 * @id         2520
 * @title      Count the Digits That Divide a Number
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/count-the-digits-that-divide-a-number/
 */
namespace Math.Easy;

public static class CountTheDigitsThatDivideANumber
{
    public static int Run(int num)
    {
        int numCopy = num;
        int counter = 0;

        while (numCopy > 0)
        {
            int remainder = numCopy % 10;
            numCopy /= 10;

            if (num % remainder == 0)
                counter++;
        }

        return counter;
    }
}


