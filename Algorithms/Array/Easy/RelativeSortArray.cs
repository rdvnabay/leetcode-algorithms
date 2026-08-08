namespace Algorithms.Array.Easy;

public static class RelativeSortArray
{
    public static int[] Run(int[] arr1, int[] arr2)
    {
        int counter = 0;

        for (int i = 0; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr1.Length; j++)
            {
                if (arr2[i] == arr1[j])
                {
                    int temp = arr1[j];
                    arr1[j] = arr1[counter];
                    arr1[counter] = temp;

                    counter++;
                }
            }
        }

        for (int i = counter; i < arr1.Length - 1; i++)
        {
            for (int j = counter + 1; j < arr1.Length; j++)
            {
                if (arr1[i] > arr1[j])
                {
                    int temp = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = temp;
                }
            }
            counter++;
        }
      
        return arr1;
    }
}
