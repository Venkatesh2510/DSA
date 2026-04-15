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
    public ListNode ReverseList(ListNode head) {
        if(head==null||head.next==null)
        {
            return head;
        }
        ListNode newHead=ReverseList(head.next);
        head.next.next=head; // reverse the front pointer
        head.next=null; // break the current pointer to next as it is reverse;
        return newHead;
    }
}
