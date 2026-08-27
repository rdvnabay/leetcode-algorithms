/**
 * @id         1952
 * @title      Three Divisors
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/three-divisors/
 */
namespace Math.Easy;

public static class ThreeDivisors
{
    //4
    public static bool Run(int n)
    {
        //4 2 1
        int divisor = 2;
        int counter = 1;

        while (n > 1)
        {
            if (n % divisor == 0)
            {
                counter++;

                if (counter > 3)
                    return false;

                n /= divisor;
            }
            else
            {
                divisor++;
            }
        }


        return counter == 3;
    }
}
