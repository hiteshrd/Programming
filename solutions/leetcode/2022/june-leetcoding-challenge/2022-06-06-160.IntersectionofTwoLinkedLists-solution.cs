/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int countA = FindCount(headA);
        int countB = FindCount(headB);
        if(countB > countA)
        {
            (headA,headB) = (headB,headA);
            (countA, countB) = (countB, countA);
        }
        while(countA != countB)
        {
            headA = headA.next;
            countA--;
        }
        while(headA != null)
        {
            if(headA== headB)
            {
                return headA;
            }
            headA = headA.next;
            headB = headB.next;
        }
        return null;
        
    }
    private int FindCount(ListNode node)
    {
        int count = 0;
        while(node != null)
        {
            count++;
            node = node.next;
        }
        return count;
    }
}
