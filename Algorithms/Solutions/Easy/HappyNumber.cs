namespace Algorithms.Solutions.Easy;

public class HappyNumber
{
    public static bool Run(int n)
    {
        List<int> totalList = new();

        while (n != 1)
        {
            double total = 0;
            int[] digitNumbers = n.ToString().Select(number => (int)number - 48).ToArray();

            for (int i = 0; i < digitNumbers.Length; i++)
                total += Math.Pow(digitNumbers[i], 2);

            n = (int)total;
            total = 0;

            if (!totalList.Contains(n))
                totalList.Add(n);
            else
                return false;
        }

        return true;
    }
}
