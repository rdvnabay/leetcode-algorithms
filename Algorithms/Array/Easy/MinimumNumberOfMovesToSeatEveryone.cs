/**
 * @id         2037
 * @title      Minimum Number of Moves to Seat Everyone
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/minimum-number-of-moves-to-seat-everyone/
 */
namespace Array.Easy;

public static class MinimumNumberOfMovesToSeatEveryone
{
    public static int Run(int[] seats, int[] students)
    {
        int total = 0;
        System.Array.Sort(seats);
        System.Array.Sort(students);

        for (int i = 0; i < students.Length; i++)
            total += Math.Abs(students[i] - seats[i]);

        return total;
    }
}


