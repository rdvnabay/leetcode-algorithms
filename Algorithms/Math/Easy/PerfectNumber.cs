/**
 * @id         507
 * @title      Perfect Number
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/perfect-number/
 */
namespace Algorithms.Math.Easy;

public static class PerfectNumber
{
    public static bool Run(int num)
    {
        if (num == 1)
            return false;

        int divisor = 2;
        List<int> divisors = new();

        while (divisor < num)
        {
            if (num % divisor == 0)
            {
                int otherDivisor = num / divisor;
                if (!divisors.Contains(otherDivisor))
                {
                    divisors.Add(otherDivisor);
                    divisors.Add(divisor);
                }
                else
                    break;
            }

            divisor++;
        }

        divisors.Add(1);
        int total = divisors.Sum();
        return total == num;
    }
}


