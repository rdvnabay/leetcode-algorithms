/**
 * @id         2591
 * @title      Distribute Money to Maximum Children
 * @topic      math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/distribute-money-to-maximum-children/
 */
namespace Math.Easy;

public static class DistributeMoneyToMaximumChildren
{
    //20 3
    public static int Run(int money, int children)
    {
        if (money < children)
            return -1;

        int limit = (8 * 1) + (1 * (children - 1));
        if (money < limit)
            return 0;

        int eightDollarCount = money / 8;
        if (money % 8 == 4 && eightDollarCount > 1)
            eightDollarCount -= 1;

        return eightDollarCount;
    }
}


