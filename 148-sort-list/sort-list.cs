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
   
    public ListNode mergeSortList(ListNode list1, ListNode list2) {
       ListNode dummyNode = new ListNode(-1);
       ListNode temp = dummyNode;

       while(list1 !=null && list2 !=null) {
           if(list1.val<=list2.val){
              temp.next = list1;
              list1 = list1.next;
           }
           else{
            temp.next = list2;
            list2 = list2.next;
           }
           temp = temp.next;
       }
       if(list1 !=null){
           temp.next = list1;
       }
      else{
           temp.next = list2;
       }
       return dummyNode.next;
    }

    public ListNode findMiddle(ListNode head){
      ListNode slow = head;
      ListNode fast = head.next;

      while(fast !=null && fast.next !=null){
        slow = slow.next;
        fast = fast.next.next;
      }
      return slow;
    }

    public ListNode SortList(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }
        ListNode middle = findMiddle(head);
        ListNode right = middle.next;
        middle.next = null;
        ListNode left = head;

        left  = SortList(left);
        right = SortList(right);
        return mergeSortList(left, right);
    }
}