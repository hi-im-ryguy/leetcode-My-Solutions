/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

/**
 * Uses recursion to merge two sorted singly-linked lists into one sorted singly-linked list.
 * THE OBJECTIVE TO IS RETURN THE SAME FUNCTION FOR THE FINAL LISTNODE'S .NEXT PARAMETER.
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
const mergeTwoLists = (l1, l2) => {
    let linkedList1 = l1;
    let linkedList2 = l2;
    let sortedList = new ListNode();
    
    // The BASE CASE. Return NULL as the last ListNode's .next parameter.
    if (linkedList1 === null && linkedList2 === null) {
        return null; 
        
    // Check to if just l1 is null. If so, continue making the final sorted linked lists values to be l2's values.
    } else if (linkedList1 === null) {
        sortedList.val = linkedList2.val;
        sortedList.next = mergeTwoLists(null, linkedList2.next);
        return sortedList;
    }
    
    // Check to if just l2 is null. If so, continue making the final sorted linked lists values to be l1's values.
    else if (linkedList2 === null) {
        sortedList.val = linkedList1.val;
        sortedList.next = mergeTwoLists(linkedList1.next, null);
        return sortedList;
    }
    
    // When BOTH l1 AND l2 have a value. Check them both, and add the lesser value to the sortedList's val parameter.
    // Then use recursion to find out sortedList's .next parameter.
    else if (linkedList1.val >= linkedList2.val) {
        sortedList.val = linkedList2.val;
        sortedList.next = mergeTwoLists(linkedList1, linkedList2.next);
        return sortedList;
    }
    
    // The opposite case as the above statement.
    else if (linkedList2.val > linkedList1.val) {
        sortedList.val = linkedList1.val;
        sortedList.next = mergeTwoLists(linkedList1.next, linkedList2);
        return sortedList;
    }
}
