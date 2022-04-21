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
public class BSTIterator {
    Stack<TreeNode> holder;

    public BSTIterator(TreeNode root) {
        holder = new Stack<TreeNode>();
        Insert(root);
    }
    private void Insert(TreeNode root)
    {
        while(root!= null)
        {
            holder.Push(root);
            root = root.left;
        }
    }
    public int Next() {
        TreeNode elem = holder.Pop();
        Insert(elem.right);
        return elem.val;
    }
    
    public bool HasNext() {
        return holder.Count() >0;
        
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
