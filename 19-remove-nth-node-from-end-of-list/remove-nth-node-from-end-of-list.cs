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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        if(head == null || head.next == null) return null;
       int len = 0;
        ListNode temp = head;

        while(temp !=null){
            len++;
            temp = temp.next;
        }
        
        temp = head;
        len = len - n;
         if(len==0) return head.next;
        int cnt = 0;
        ListNode prev = null;

        while(temp !=null)
        {
            if(cnt == len){
              prev.next = prev.next.next;
            }
            cnt++;
            
            prev = temp;
            temp = temp.next;
        }
        
        return head; 
    }
}