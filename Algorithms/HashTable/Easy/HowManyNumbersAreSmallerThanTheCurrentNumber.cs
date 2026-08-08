namespace Algorithms.HashTable.Easy;

public static class HowManyNumbersAreSmallerThanTheCurrentNumber
{
    public static int[] Run(int[] nums)
    {
        Dictionary<int, int> dict = new();
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.TryGetValue(nums[i], out int value))
            {
                result[i] = value;
            }
            else
            {
                int count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                        count++;
                }

                result[i] = count;
                dict.Add(nums[i], count);
            }
        }

        return result;
    }

    //Other solutions
    public static int[] Solution2(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                    count++;
            }

            result[i] = count;
        }

        return result;
    }

    public static int[] Solution3(int[] nums)
    {
        Dictionary<int, int> frequency = new();

        foreach (int num in nums)
        {
            if (frequency.TryGetValue(num, out int count))
                frequency[num] = count + 1;
            else
                frequency[num] = 1;
        }

        Dictionary<int, int> smallerCount = new();

        foreach (var current in frequency)
        {
            int count = 0;

            foreach (var other in frequency)
            {
                if (other.Key < current.Key)
                    count += other.Value;
            }

            smallerCount[current.Key] = count;
        }

        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = smallerCount[nums[i]];
        }

        return result;
    }
}
