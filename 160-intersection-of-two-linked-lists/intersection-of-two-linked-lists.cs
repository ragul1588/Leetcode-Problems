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
        
        int t1 =0;
        int t2 =0;
        int size =0;
        ListNode temp1 = headA;
        ListNode temp2 = headB;
        ListNode result = null;

        while(temp1 !=null){
            if(temp1 !=null){
            t1++;
            temp1 = temp1.next;
           }
        }
        
        while(temp2 !=null){
           if(temp2 !=null){
            t2++;
            temp2 = temp2.next;
           }
        }

        if(t1>t2){
           return collesion(headA, headB, t1-t2);
        }
        else{
           return collesion(headB, headA, t2-t1);
        }
    }

    public ListNode collesion(ListNode temp1, ListNode temp2, int k){
        while(k>0){
            temp1 = temp1.next;
            k--;
        }
        while(temp1 != temp2){         
           temp1 = temp1.next;
           temp2 = temp2.next;
        }
        return temp1;
    }
}