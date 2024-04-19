using System;
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null!, TreeNode right = null!)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

/* 
Source: https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
Given the root of a binary tree, return its maximum depth.
A binary tree's maximum depth is the number of nodes along the longest 
path from the root node down to the farthest leaf node. 
*/
public class BinaryTreeMaxHeightProblem
{

    public int MaxDepth(TreeNode root)
    {

        if (root == null)
        {
            return 0;
        }

        return Math.Max(MaxDepth(root.left) + 1, MaxDepth(root.right) + 1);
    }
}