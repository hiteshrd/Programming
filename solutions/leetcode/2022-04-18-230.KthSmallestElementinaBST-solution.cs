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
    public int KthSmallest(TreeNode root, int k) {
        SortedDictionary<int,int> myDic = new SortedDictionary<int,int>();
        CollectNodes(root, ref myDic);
        int counter = 1;
        foreach( var item in myDic)
        {
            if(counter == k)
                return item.Key;
            counter++;
        }
        return 0;
    }
    private void CollectNodes(TreeNode root, ref SortedDictionary<int,int> myDic)
    {
        if(root== null)
            return;
        CollectNodes(root.left, ref myDic);
        myDic.Add(root.val,root.val);
        CollectNodes(root.right, ref myDic);
    }
}
