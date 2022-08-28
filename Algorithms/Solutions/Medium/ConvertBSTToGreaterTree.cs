namespace Algorithms.Solutions.Medium;
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


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}