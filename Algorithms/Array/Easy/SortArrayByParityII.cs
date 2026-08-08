namespace Algorithms.Array.Easy;

public static class SortArrayByParityII
{
    public static int[] Run(int[] nums)
    {
        // 4, 2, 5, 7
        List<int> list = new();
        bool isEvenIndex = true;
        bool isOddIndex = true;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0 && nums[i] % 2 == 1)
            {
                list.Add(i);
                isEvenIndex = true;

                if (isEvenIndex && isOddIndex)
                {

                }
                //index çift, sayý tek
            }
            else if (i % 2 == 1 && nums[i] % 2 == 0)
            {
                list.Add(i);
                isOddIndex = true;
                //index tek, sayý çift

            }
        }
        return null;
    }
}