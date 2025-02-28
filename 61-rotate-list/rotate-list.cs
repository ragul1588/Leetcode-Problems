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
    public ListNode KthNode(ListNode head, int k){
       int cnt = 1;
       while(head !=null){
         if(cnt == k) return head;
         cnt++;
         head = head.next;
       }
       return head;
    }

    public ListNode RotateRight(ListNode head, int k) {
        
        if(head == null || k == 0) return head;

        ListNode tail = head;
        int len = 1;
        while(tail.next != null){
          len++;
          tail = tail.next;
        }
        if(k%len == 0) return head;

        k = k%len;
        tail.next = head;

        ListNode LastNode = KthNode(head, len-k);
        head = LastNode.next;
        LastNode.next = null;

        return head;
    }
}