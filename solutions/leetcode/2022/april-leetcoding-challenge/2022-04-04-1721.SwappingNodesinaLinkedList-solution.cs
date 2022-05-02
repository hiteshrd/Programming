/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode SwapNodes(ListNode head, int k) {
         
        ListNode current = head;
        int counter = 1;
        Dictionary<int,int> myDic = new Dictionary<int,int>();
        myDic[counter] = current.val;
        while(current.next != null)
        {
            current = current.next;
            counter++; 
            myDic[counter] = current.val;
        }
        current = head;
        for(int i = 1; i<=counter; i++)
        {
            if(i == counter-k+1)
            {          
                current.val = myDic[k];
            }
            if(i == k)
            {
                current.val = myDic[counter-k+1];
            }
            current = current.next;
        }
        return head;
    }
}
