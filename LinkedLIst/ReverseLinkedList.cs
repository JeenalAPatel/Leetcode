using System.Collections.Generic;
namespace LeetCode
{
    public class ReverseLinkedList
    {
        public ListNode listHead;
        public ReverseLinkedList(List<int> list1)
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
        public ListNode? ReverseList(ListNode? head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode prev=null;
            var curr = head;
            var nextNode = head?.next;
            while (curr != null)
            {
                curr.next = prev;
                prev = curr;
                curr = nextNode;
                nextNode = nextNode?.next;
            }

            return prev;
        }
    }
}
// if(head==null)
// {
//     return null;
// }
// ListNode prev=null;
// var curr=head;
// var NextNode=head.next;
//         
// while(curr!=null)
// {
//     curr.next=prev;
//     prev=curr;
//     curr=NextNode;
//     NextNode=NextNode?.next;
// }
// return prev;