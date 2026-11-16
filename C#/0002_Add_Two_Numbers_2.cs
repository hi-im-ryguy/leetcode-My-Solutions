using System;

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
        ListNode answer = new ListNode();
        int sum = l1.val + l2.val;
        (int quotient, int remainder) = Math.DivRem(sum, 10);
        answer.val = remainder;
        if (l1.next == null && l2.next == null) {
            if (quotient == 1) answer.next = new ListNode(quotient);
            return answer;
        }
        if (l1.next == null) l1.next = new ListNode();
        if (l2.next == null) l2.next = new ListNode();

        l1.next.val += (quotient != 0) ? 1 : 0;

        answer.next = AddTwoNumbers(l1.next, l2.next);
        return answer;
    }
}
