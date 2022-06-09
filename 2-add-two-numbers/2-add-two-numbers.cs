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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        bool hasNext = true;
        ListNode headNode = null;        
        ListNode pointerNode = null;
        bool hasNextValToAdd = false;
        while(hasNext)
        {
            int fromPrevVal = hasNextValToAdd ? 1 : 0;  
            int sum = fromPrevVal + (l1?.val ?? 0) + (l2?.val ?? 0);
            int currentVal = sum % 10;
            hasNextValToAdd = sum >= 10;
            
            if(headNode is null)
                headNode = pointerNode = new ListNode(currentVal);                                
            else 
            {   
                pointerNode.next = new ListNode(currentVal);   
                pointerNode = pointerNode.next;
            }
            l1 = l1?.next;            
            l2 = l2?.next;  
            hasNext = l1 is not null || l2 is not null || hasNextValToAdd;
        }
        return headNode;
    }
}