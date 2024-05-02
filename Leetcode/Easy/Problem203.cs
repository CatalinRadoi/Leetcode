namespace Leetcode.Easy;

public class Problem203
{
    public ListNode? RemoveElements(ListNode? head, int val)
    {
        // Create a dummy node to handle the case where the head needs to be removed
        var dummy = new ListNode();
        dummy.next = head;
        var prev = dummy;
        var current = head;

        while (current != null)
        {
            if (current.val == val)
            {
                // Remove the current node by updating the next pointer of the previous node
                prev.next = current.next;
            }
            else
            {
                // Move the previous pointer to the current node
                prev = current;
            }

            // Move to the next node
            current = current.next;
        }

        // Return the head of the modified list, skipping the dummy node
        return dummy.next;
    }


    public class ListNode
    {
        public ListNode? next;
        public int val;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}