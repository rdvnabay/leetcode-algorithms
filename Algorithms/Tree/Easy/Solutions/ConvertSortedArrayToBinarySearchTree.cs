using Algorithms.Common;

namespace Algorithms.Tree.Easy.Solutions;

public class ConvertSortedArrayToBinarySearchTree
{
    public static TreeNode Run(int[] nums)
    {
        var isEven = nums.Length % 2 == 0;

        return isEven
            ? EvenTree(nums)
            : OddTree(nums);
    }

    public static TreeNode OddTree(int[] nums)
    {
        var midIndex = nums.Length / 2;
        var rootValue = nums[midIndex];

        TreeNode tree = new(rootValue);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i == midIndex)
                continue;

            if (nums[i] < rootValue)
            {
                if (tree.left is null)
                    tree.left = new TreeNode(nums[i]);
                else
                {
                    var currentLeft = tree.left;
                    currentLeft.left = new TreeNode(nums[i]);
                }
            }
            else
            {
                if (tree.right is null)
                    tree.right = new TreeNode(nums[i]);
                else
                {
                    var currentRight = tree.right;
                    currentRight.right = new TreeNode(nums[i]);
                }
            }
        }

        return tree;
    }

    public static TreeNode EvenTree(int[] nums)
    {
        return null;
    }
}
