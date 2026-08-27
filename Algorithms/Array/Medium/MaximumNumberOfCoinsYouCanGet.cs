/**
 * @id         1561
 * @title      Maximum Number of Coins You Can Get
 * @topic      Array
 * @difficulty Medium
 * @link       https://leetcode.com/problems/maximum-number-of-coins-you-can-get/
 */
namespace Array.Medium;

public static class MaximumNumberOfCoinsYouCanGet
{
    public static int Run(int[] piles)
    {
        int total = 0;
        int rounds = piles.Length / 3;
        
        System.Array.Sort(piles);
        
        for (int i = piles.Length - 2; i >= 0; i -= 2)
        {
            if (rounds == 0)
                break;

            total += piles[i];
            rounds--;
        }
        
        return total;
    }
}


