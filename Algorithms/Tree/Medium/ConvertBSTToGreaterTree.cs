using Algorithms.Common;

namespace Algorithms.Tree.Medium;

public class ConvertBSTToGreaterTree
{
    public static TreeNode Run(TreeNode root)
    {
        int sumOfValues = 0;
        Traverse(root, ref sumOfValues);

        static void Traverse(TreeNode node, ref int sumOfValues)
        {
            if (node is null)
                return;

            if (node.right is not null)
                Traverse(node.right, ref sumOfValues);

            int temp = node.val;
            node.val += sumOfValues;
            sumOfValues += temp;

            if (node.left is not null)
                Traverse(node.left, ref sumOfValues);
        }
        return root;
    }
}