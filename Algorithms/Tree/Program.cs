// Demo runner for 4 indexed solution files. Canonical ordering: LeetCode problem ID.
using Algorithms.Common;
using Algorithms.Tree.Easy;
using Algorithms.Tree.Medium;

Console.WriteLine("=== Tree Algorithms ===");

// --- Easy ------------------------------------------------------------
ConvertSortedArrayToBinarySearchTree.Run(new int[] { -10, -3, 0, 5, 9 });
SameTree.Run(new TreeNode(1, left: new TreeNode(2)), new TreeNode(1, right: new TreeNode(2)));

// --- Medium ------------------------------------------------------------


