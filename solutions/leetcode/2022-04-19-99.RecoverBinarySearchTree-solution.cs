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
        TreeNode firstNode = null;
        TreeNode secondNode = null;
        TreeNode previousNode = null;
    public void RecoverTree(TreeNode root) {       
        if(root == null)
            return;
        ValidateTree(root);
        int temp = firstNode.val;
        firstNode.val = secondNode.val;
        secondNode.val = temp;
    }
    
    private void ValidateTree(TreeNode root)
    {
        if (root == null)
            return;
        ValidateTree(root.left);
        if(previousNode != null && root.val <previousNode.val)
        {
            if(firstNode == null)
            {
                firstNode = previousNode;
            }
            secondNode = root;
        }
        previousNode = root;
        ValidateTree(root.right);
    }
}
