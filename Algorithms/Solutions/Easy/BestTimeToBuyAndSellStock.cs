namespace Algorithms.Solutions.Easy;

public class BestTimeToBuyAndSellStock
{
    public static int Run(int[] prices)
    {
        int counter = 1;
        int output = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (counter > prices.Length - 1) break;

            int current = prices[i];
            int next = prices[counter];

            if (next > current)
            {
                int result = next - prices[i];
                i--;
                counter++;

                if (result > output)
                    output = result;
            }
            else
                counter = i + 2;
        }
        return output;
    }
}
