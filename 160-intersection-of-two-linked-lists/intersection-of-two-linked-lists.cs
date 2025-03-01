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
        
        List<ListNode> li = new List<ListNode>();
        while(headA !=null)
        {
          li.Add(headA);
          headA = headA.next;
        }
        while(headB !=null)
        {
          if(li.Contains(headB)){
            return headB;
          }
          headB = headB.next;
        }

        return null;
    }
}