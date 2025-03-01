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
        
        ListNode temp1 = headA;
        ListNode temp2 = headB;
        if(temp1 == null || temp2 == null) return null;

        while(temp1 != temp2){
            temp1 = temp1.next;
            temp2 = temp2.next;
            if(temp1 == temp2) return temp1;
            if(temp1 == null) temp1 = headB;
            if(temp2 == null) temp2 = headA;
        }
        return temp1;
    }
}