/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode ConvertBST(TreeNode root) {
        int val = 0;
        if(root != null)
        {
            root = ProcessBST(root, ref val);
        }
        return root;
    }
    private TreeNode ProcessBST(TreeNode root, ref int val)
        {
        if(root.right !=null)
            {
            root.right = ProcessBST(root.right, ref val);
            }
        val += root.val;
        root.val = val;
        if(root.left !=null)
            {
            root.left = ProcessBST(root.left, ref val);
            }
        return root;
        }
}
