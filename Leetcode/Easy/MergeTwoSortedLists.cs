
namespace Leetcode.Easy;
public static class MergeTwoListsSolution
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var head = new ListNode();
        var dummy = head;

        var head1 = list1;
        var head2 = list2;

        while (head1 != null || head2 != null)
        {
            if (head1 == null)
            {
                while (head2 != null)
                {
                    head.Next = new ListNode(head2.Val);
                    head = head.Next;
                    head2 = head2.Next;
                }

                break;
            }

            if (head2 == null)
            {
                while (head1 != null)
                {
                    head.Next = new ListNode(head1.Val);
                    head = head.Next;
                    head1 = head1.Next;
                }

                break;
            }

            if (head1.Val < head2.Val)
            {
                head.Next = new ListNode(head1.Val);
                head = head.Next;
                head1 = head1.Next;
            }
            else
            {
                head.Next = new ListNode(head2.Val);
                head = head.Next;
                head2 = head2.Next;
            }
        }

        return dummy.Next ?? new ListNode();
    }
    public class ListNode(int val = 0, ListNode? next = null)
    {
        public int Val { get; set; } = val;
        public ListNode? Next { get; set; } = next;
    }
}