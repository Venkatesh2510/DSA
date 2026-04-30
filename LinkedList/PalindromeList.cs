// 234. Palindrome Linked List

// Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

 

// Example 1:


// Input: head = [1,2,2,1]
// Output: true
// Example 2:


// Input: head = [1,2]
// Output: false
 

// Constraints:

// The number of nodes in the list is in the range [1, 105].
// 0 <= Node.val <= 9
 

// Follow up: Could you do it in O(n) time and O(1) space?


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
    public bool IsPalindrome(ListNode head) {
        if(head==null||head.next==null)
        {
            return true;
        }
        ListNode fast=head;
        ListNode curr=head;
        ListNode prev=null;
        while(fast!=null&&fast.next!=null)
        {
            fast=fast.next.next;

            ListNode temp=curr.next;
            curr.next=prev;
            prev=curr;
            curr=temp;
        }
        if(fast!=null)
        {
            curr=curr.next;
        }
        ListNode first=prev;
        ListNode second=curr;
        Console.WriteLine(first.val);
        Console.WriteLine(second.val);
        while(first!=null&&second!=null)
        {
            if(first.val!=second.val)
            {
                return false;
            }
            first=first.next;
            second=second.next;
        }
        return true;
    }
}
