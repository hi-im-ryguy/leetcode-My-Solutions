/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carryFlag = 0;
        int val = l1.val + l2.val;
        if (val >= 10)
        {
            carryFlag++;
            val -= 10;
        }

        ListNode thisListNode = new ListNode(val);

        if (l1.next == null && l2.next == null)
        {
            thisListNode.val += carryFlag;
            return thisListNode;
        }
        else if (l1.next == null)
        {
            l2.next.val += carryFlag;
            thisListNode.next = AddTwoNumbers(new ListNode(0), l2.next);
        }
        else if (l2.next == null)
        {
            l1.next.val += carryFlag;
            thisListNode.next = AddTwoNumbers(l1.next, new ListNode(0));
        }
        else
        {
            l1.next.val += carryFlag;
            thisListNode.next = AddTwoNumbers(l1.next, l2.next);
        }

        return thisListNode;
    }
}
