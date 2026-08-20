namespace Math.Easy;

public static class AccountBalanceAfterRoundedPurchase
{
    //
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
}
