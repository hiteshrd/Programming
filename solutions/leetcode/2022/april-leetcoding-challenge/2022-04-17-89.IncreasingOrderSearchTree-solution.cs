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
    public TreeNode IncreasingBST(TreeNode root) {
        SortedDictionary<int,int> myDic = new SortedDictionary<int, int>();
        TreeNode result = null;
        CollectNodes(root, ref myDic);
        TreeNode current = null;
        foreach(var item in myDic.Reverse())
            {
            var temp = new TreeNode();

            temp.val = item.Key;
            temp.right= current;
            current = temp;

            }
        return current;
    }
    private void CollectNodes(TreeNode root, ref SortedDictionary<int,int> myDic)
        {
        if (root != null)
        {
        CollectNodes(root.left, ref myDic);
        myDic.Add(root.val,root.val);
        CollectNodes(root.right,ref myDic);
        }
        }
        
}
