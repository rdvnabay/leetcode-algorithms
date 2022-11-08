namespace Algorithms.Solutions.Easy;

public static class SummaryRanges
{
    public static IList<string> Run(int[] nums)
    {
        List<string> result = new();
        string currentValue = "";
        int counter = 0;
        int lastIndex = nums.Length - 2;
        bool isOpened = false;

        if (nums.Length == 1)
            result.Add(nums[0].ToString());

        for (int i = 0; i < nums.Length - 1; i++)
        {
            int current = nums[i];
            int next = nums[i + 1];

            int diff = next - current;

            if (diff == 1)
            {
                isOpened = true;
                counter++;

                if (counter == 1)
                {
                    if (i != lastIndex)
                        currentValue = current.ToString();
                    else
                        result.Add($"{current}->{next}");
                }
                else if (i == lastIndex)
                    result.Add($"{currentValue}->{next}");


            }

            else
            {
                if (!isOpened)
                {
                    result.Add(current.ToString());
                    if (i == lastIndex)
                        result.Add(next.ToString());
                }

                else
                {
                    currentValue += $"->{current}";
                    result.Add(currentValue);
                    currentValue = "";
                    isOpened = false;
                    counter = 0;

                    if (i == lastIndex)
                        result.Add(next.ToString());
                }
            }
        }

        return result;
    }
}
