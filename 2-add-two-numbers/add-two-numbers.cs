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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode temp = l1;
        ListNode temp1 = l2;
        ListNode total = new ListNode(-1);
        ListNode tempResult = total;
        int sum =0;
        int carry =0;

       while(temp !=null || temp1 !=null){
           sum = carry;
           if(temp !=null) sum +=temp.val;
           if(temp1 !=null) sum +=temp1.val;

           ListNode x = new ListNode(sum%10);
           tempResult.next = x;
           tempResult = x;

           carry = sum/10;
           if(temp !=null) temp = temp.next;
           if(temp1 !=null) temp1 = temp1.next;
       }
       if(carry !=0){
         tempResult.next = new ListNode(carry);
       }
       return total.next;
    }
}