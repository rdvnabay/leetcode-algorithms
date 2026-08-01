namespace Algorithms.Array.Easy;

public class FindAllNumbersDisappearedInAnArray
{
    public static IList<int> Run(int[] nums)
    {
        int[] checkList = new int[nums.Length];
        List<int> result = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int numIndex = nums[i] - 1;
            if(checkList[numIndex] == 0)
                checkList[numIndex] = nums[i];
        }

        for (int i = 0; i < checkList.Length; i++)
        {
            if (checkList[i] == 0)
                result.Add(i + 1);
        }
        return result;
    }
}
