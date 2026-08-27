/**
 * @id         2798
 * @title      Number of Employees Who Met the Target
 * @topic      Array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-employees-who-met-the-target/
 */
namespace Array.Easy;

public static class NumberOfEmployeesWhoMetTheTarget
{
    public static int Run(int[] hours, int target)
    {
        int result = 0;

        foreach (var hour in hours)
        {
            if (hour >= target)
                result++;
        }

        return result;
    }
}


