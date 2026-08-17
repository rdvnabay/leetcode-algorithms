namespace Array.Easy;

public static class RichestCustomerWealth
{
    //[1,5],[7,3],[3,5]
    public static int Run(int[][] accounts)
    {
        int maxValue = int.MinValue;

        for (int i = 0; i < accounts.Length; i++)
        {
            int total = 0;

            for (int j = 0; j < accounts[i].Length; j++)
                total += accounts[i][j];

            if(total>maxValue)
                maxValue= total;    
        }

        return maxValue;
    }
}
