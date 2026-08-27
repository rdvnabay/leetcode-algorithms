/**
 * @id         2806
 * @title      Account Balance After Rounded Purchase
 * @topic      Math
 * @difficulty Easy
 * @link       https://leetcode.com/problems/account-balance-after-rounded-purchase/
 */
namespace Math.Easy;

public static class AccountBalanceAfterRoundedPurchase
{
    public static int Run(int purchaseAmount)
    {
        int accountBalance = 100;
        int remainder = purchaseAmount % 10;

        if (remainder >= 5)
            purchaseAmount += 10 - remainder;
        else
            purchaseAmount -= remainder;

        return accountBalance - purchaseAmount;
    }

    //Alternative solutions
    static int Solution2(int purchaseAmount)
    {
        double val = (double)purchaseAmount / 10;
        int sum = (int)System.Math.Round(val, MidpointRounding.AwayFromZero) * 10;
        return 100 - sum;
    }
}


