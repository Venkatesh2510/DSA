<!-- 86. Partition List

Given the head of a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.

You should preserve the original relative order of the nodes in each of the two partitions.

 

Example 1:


Input: head = [1,4,3,2,5,2], x = 3
Output: [1,2,2,4,3,5]
Example 2:

Input: head = [2,1], x = 2
Output: [1,2]
 

Constraints:

The number of nodes in the list is in the range [0, 200].
-100 <= Node.val <= 100
-200 <= x <= 200 -->

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
    public ListNode Partition(ListNode head, int x) {
        ListNode before=new ListNode(0);
        ListNode dummyB=before;
        ListNode after=new ListNode(0);
        ListNode dummyA=after;
        while(head!=null)
        {
            ListNode next=head.next;
            head.next=null;
            if(head.val<x)
            {
                before.next=head;
                before=before.next;
            }else{
                after.next=head;
                after=after.next;
            }
            head=next;
        }
        before.next=dummyA.next;
        dummyB=dummyB.next;
        return dummyB;
    }
}
