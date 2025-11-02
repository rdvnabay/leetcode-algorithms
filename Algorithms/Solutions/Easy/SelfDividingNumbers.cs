namespace Algorithms.Solutions.Easy;

public static class SelfDividingNumbers
{
    public static IList<int> Run(int left, int right)
    {
        List<int> result = new();
        for (int num = left; num <= right; num++)
        {
            string numStr = num.ToString();
            if (numStr.Length == 1)
            {
                result.Add(num);
                continue;
            }

            else if (numStr.Contains("0"))
                continue;

            bool isSelfDividing = true;
            for (int i = 0; i < numStr.Length; i++)
            {
                int currentDigit = int.Parse(numStr[i].ToString());
                if (num % currentDigit != 0)
                {
                    isSelfDividing = false;
                    continue;
                }
            }

            if (isSelfDividing)
                result.Add(num);
        }
        return result;
    }
}
