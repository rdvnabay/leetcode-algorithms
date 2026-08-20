/**
 * @id         860
 * @title      Lemonade Change
 * @topic      array
 * @difficulty Easy
 * @link       https://leetcode.com/problems/lemonade-change/
 */
namespace Algorithms.Array.Easy;

public static class LemonadeChange
{
    public static bool Run(int[] bills)
    {
        const int LemonadePrice = 5;
        int fiveDollarBills = 0;
        int tenDollarBills = 0;

        foreach (var bill in bills)
        {
            if (bill == LemonadePrice)
                fiveDollarBills++;

            else if (bill == 10)
            {
                if (fiveDollarBills <= 0)
                    return false;

                fiveDollarBills--;
                tenDollarBills++;
            }

            else
            {
                if (fiveDollarBills <= 0)
                    return false;

                if (tenDollarBills <= 0)
                {
                    if (fiveDollarBills < 3)
                        return false;
                    else
                        fiveDollarBills -= 3;

                }
                else
                {
                    fiveDollarBills--;
                    tenDollarBills--;
                }
            }
        }

        return true;
    }
}


