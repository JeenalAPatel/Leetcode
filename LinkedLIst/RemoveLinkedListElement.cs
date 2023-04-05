using System.Collections.Generic;
namespace LeetCode
{
    public class RemoveLinkedListElement
    {
        public ListNode listHead;
        public RemoveLinkedListElement(List<int> list1)
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

        public ListNode? RemoveElements(ListNode? head, int val)
        {
            if (head == null)
            {
                return null;
            }

            var dummy = new ListNode(0);
            dummy.next = head;
            var prev = dummy;
            var curr = head;
            while (curr != null)
            {
               
                if (curr.val == val)
                {
                    prev.next = curr.next;
                    
                }
                else
                {
                    prev = prev.next;
                }
                curr = curr.next;
                

            }

            return dummy.next;
        }
    }
}
// var dummy=new ListNode(0);
// dummy.next=head;
// var cur=head;
// var prev=dummy;
// while(cur!=null)
// {
//             
//     if(cur.val==val)
//     {
//         prev.next=cur.next;
//                 
//     }
//     else
//     {
//         prev=prev.next;
//                 
//     }
//     cur=cur.next;
// }
// return dummy.next;