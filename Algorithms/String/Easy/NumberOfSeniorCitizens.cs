/**
 * @id         2678
 * @title      Number of Senior Citizens
 * @topic      string
 * @difficulty Easy
 * @link       https://leetcode.com/problems/number-of-senior-citizens/
 */
namespace String.Easy;

public static class NumberOfSeniorCitizens
{
    public static int Run(string[] details)
    {
        const int AGE_LIMIT = 60;
        int counter = 0;

        foreach (var detail in details)
        {
            var age = int.Parse($"{detail[^4]}{detail[^3]}");
            if (age > AGE_LIMIT)
                counter++;
        }

        return counter;
    }
}


