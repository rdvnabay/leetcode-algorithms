namespace Array.Medium;

public static class FindThePrefixCommonArrayOfTwoArrays
{
    //{ 2, 3, 1 }, new int[] { 3, 1, 2 }
    public static int[] Run(int[] A, int[] B)
    {
        HashSet<int> numbers = new();
        int[] result = new int[A.Length];

        for (int i = 0; i < A.Length; i++)
        {
            numbers.Add(A[i]);
            numbers.Add(B[i]);

            if (numbers.Count == i + 1)
                result[i] = i + 1;
            else
                result[i] = (i + 1) * 2 % numbers.Count;
        }

        return result;
    }
}
