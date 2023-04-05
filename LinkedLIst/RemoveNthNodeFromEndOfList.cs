using System.Collections.Generic;
namespace LeetCode
{
    public class RemoveNthNodeFromEndOfList
    {
        public ListNode listHead;
        public RemoveNthNodeFromEndOfList(List<int> list1)
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
        public ListNode? RemoveNthFromEnd(ListNode? head, int n)
        {
            if (head == null)
            {
                return null;
            }

            var dummy = new ListNode(0);
            dummy.next = head;
            var curr = head;
            var len = 0;
            while (curr != null)
            {
                curr = curr.next;
                len += 1;
            }

            curr = dummy;
            var node = len - n;
            for (int i = 0; i < node; i++)
            {
                curr = curr.next;
            }

            curr.next = curr.next?.next;
            
            return dummy.next;
        }
    }
}
// var cnt=0;
// var dummy=new ListNode(0);
// dummy.next=head;
// var ptr1=dummy;
// var ptr2=dummy;
// if(head==null)
// {
//     return null;
// }
// while(cnt<=n)
// {
//     ptr1=ptr1.next;
//     cnt+=1;
// }
// while(ptr1!=null)
// {
//             
//     ptr2=ptr2.next;
//     ptr1=ptr1.next;
// }
// ptr2.next=ptr2.next.next;
// return dummy.next;