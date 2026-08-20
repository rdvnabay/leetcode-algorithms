/**
 * @id         1103
 * @title      Distribute Candies to People
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/distribute-candies-to-people/
 */
namespace Math.Easy;

public static class DistributeCandiesToPeople
{
    public static int[] Run(int candies, int num_people)
    {
        int counter = 0;
        int[] result = new int[num_people];

        for (int i = 0; i < num_people; i++)
        {
            counter++;
            int remainder = candies - counter;

            if (remainder >= 0)
            {
                candies -= counter;
                result[i] += counter;

                if (i == num_people - 1)
                    i = -1;
            }
            else
            {
                result[i] += candies;
                break;
            }
        }

        return result;
    }
}


