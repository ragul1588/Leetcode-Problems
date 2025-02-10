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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode result = new ListNode(-1);
        ListNode temp = result;

    while(list1 !=null && list2 !=null) {
        if(list1.val<list2.val){
            ListNode x = new ListNode(list1.val);
            temp.next = x;
            temp = x;
            list1 = list1.next;
        }
        else{
            ListNode x = new ListNode(list2.val);
            temp.next = x;
            temp = x;
            list2 = list2.next;
        }
    }

    while(list1 !=null){
        ListNode x = new ListNode(list1.val);
        temp.next = x;
        temp = x;
        list1 = list1.next;
    }

    while(list2 !=null){
        ListNode x = new ListNode(list2.val);
        temp.next = x;
        temp = x;
        list2 = list2.next;
    }
     return result.next;
  } 
}