/**
 * @id         771
 * @title      Jewels and Stones
 * @topic      String
 * @difficulty Easy
 * @link       https://leetcode.com/problems/jewels-and-stones/
 */
namespace String.Easy;

public static class JewelsAndStones
{
    public static int Run(string jewels, string stones)
    {
        int count = 0;
        for (int i = 0; i < stones.Length; i++)
        {
            if (jewels.Contains(stones[i]))
                count++;
        }
        return count;
    }
}


