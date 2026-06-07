// 19. Remove Nth Node From End of List

// Given the head of a linked list, remove the nth node from the end of the list and return its head.

 

// Example 1:


// Input: head = [1,2,3,4,5], n = 2
// Output: [1,2,3,5]
// Example 2:

// Input: head = [1], n = 1
// Output: []
// Example 3:

// Input: head = [1,2], n = 1
// Output: [1]
 

// Constraints:

// The number of nodes in the list is sz.
// 1 <= sz <= 30
// 0 <= Node.val <= 100
// 1 <= n <= sz
 

// Follow up: Could you do this in one pass?

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
        ListNode t=new ListNode(0);
        t.next=head;
        ListNode ans=t;
        int len=0;
        while(t!=null)
        {
            len++;
            Console.WriteLine(t.val);
            t=t.next;
        }
        int loop=len-n-1;
        t=ans;
        while(t!=null&&loop>0)
        {
            loop--;
            t=t.next;
        }
        t.next= t.next!=null ? t.next.next : null;
        return ans.next;
    }
}
