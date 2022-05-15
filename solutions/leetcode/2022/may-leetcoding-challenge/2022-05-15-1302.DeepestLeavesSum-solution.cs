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
    SortedDictionary<int,int> dic;
    public int DeepestLeavesSum(TreeNode root) {
        dic = new SortedDictionary<int,int>();
        FindSum(root, 0);
        return dic[dic.Keys.Last()];
    }
    private void FindSum(TreeNode root, int level)
    {
        if(root == null)
            return;
        int val;
        dic.TryGetValue(level, out val);
        val += root.val;
        dic[level] = val;
        level++;
        FindSum(root.left, level);
        FindSum(root.right, level);
    }
}
