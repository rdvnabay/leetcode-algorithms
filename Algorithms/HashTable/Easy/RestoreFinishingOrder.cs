/**
 * @id         3668
 * @title      Restore Finishing Order
 * @topic      HashTable
 * @difficulty Easy
 * @link       https://leetcode.com/problems/restore-finishing-order/
 */
namespace HashTable.Easy;

public static class RestoreFinishingOrder
{
    public static int[] Run(int[] order, int[] friends)
    {
        HashSet<int> setFriends = new(friends);
        int[] result = new int[friends.Length];

        int index = 0;
        for (int i = 0; i < order.Length; i++)
        {
            if (setFriends.Contains(order[i]))
            {
                result[index] = order[i];
                index++;
            }
        }

        return result;
    }
}
