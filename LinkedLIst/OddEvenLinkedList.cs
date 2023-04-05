using System.Collections.Generic;
namespace LeetCode
{
    public class OddEvenLinkedList
    {
        public ListNode listHead;
        public OddEvenLinkedList(List<int> list1)
        {
            var curr = new ListNode(0);
            listHead = curr;
            for (int i = 0; i < list1.Count; i++)
            {
                curr.next = new ListNode(list1[i]);
                curr = curr.next;
            }

            listHead = listHead.next;
        }

        public ListNode? OddEvenList(ListNode? head)
        {
            if (head == null)
            {
                return null;
            }

           
            var odd = head;
            var even = head?.next;
            var evenHead=head?.next;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenHead;
            return head;
        }
        
    }
}
// if(head==null)
// {
//     return null;
// }
// var odd=head;
// var even=head.next;
// var evenHead=head.next;
// while(even!=null&&even.next!=null)
// {
//     odd.next=even.next;
//     odd=odd.next;
//     even.next=odd.next;
//     even=even.next;
// }
// odd.next=evenHead;
// return head;