/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        //Node current = root;
        //current.next = null;
        if(root == null)
        {
            return root;
        }
        Queue<Node> qe = new Queue<Node>();
        qe.Enqueue(root);
        while(qe.Count > 0)
        {
            int count = qe.Count;
            for(int i = 0; i< count;i++)
            {
                var current  = qe.Dequeue();
                if(current.left != null)
                {
                    qe.Enqueue(current.left);
                }
                if(current.right != null)
                {
                    qe.Enqueue(current.right);
                }
                current.next = i == count-1? null: qe.Peek();
            }
        }
        return root;
        
    }
}
