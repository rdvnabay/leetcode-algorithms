using Algorithms.Common;
using Tree.Easy;

namespace Algorithms.Tree.Easy;

public static class TreeEasyRunner
{
    public static void Run()
    {
        ConvertSortedArrayToBinarySearchTree.Run(new int[] { -10, -3, 0, 5, 9 });
        SameTree.Run(new TreeNode(1, left: new TreeNode(2)), new TreeNode(1, right: new TreeNode(2)));
        //BinaryTreePaths.Run(
        //    new TreeNode(1, left: new TreeNode(2, right: new TreeNode(5)), right: new TreeNode(3)));
    }
}