/**
 * @id         3516
 * @title      Find Closest Person
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/find-closest-person/
 */
namespace Math.Easy;

public static class FindClosestPerson
{
    //2 7 4
    public static int Run(int x, int y, int z)
    {
        int first = System.Math.Abs(x - z);
        int second = System.Math.Abs(y - z);

        if (first == second)
            return 0;

        return first > second ? 1 : 2;
    }
}


