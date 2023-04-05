using System.Collections.Generic;
namespace LeetCode
{
    public class PalindromeLinkedList
    {
        public ListNode listHead;
        public PalindromeLinkedList(List<int> list1)
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

        public bool IsPalindrome(ListNode? head)
        {
            if (head?.next == null ||head==null )
            {
                return true;
            }

            var curr = head;
            var len = 0;
            while (curr != null)
            {
                curr = curr.next;
                len += 1;
            }

            curr = head;
            var nextNode = head?.next;
            ListNode prev = null;
            var div = len / 2;
            var mod = len % 2;
            for (int i = 0; i < div; i++)
            {
                curr.next = prev;
                prev = curr;
                curr = nextNode;
                nextNode = nextNode?.next;
            }

            if (mod == 1)
            {
                curr = curr?.next;
            }

            while (curr != null)
            {
                if (curr.val != prev?.val)
                {
                    return false;
                }

                curr = curr.next;
                prev = prev?.next;
            }

            return true;
        }
    }
}
// if(head==null||head.next==null)    
// {
//     return true;
// }
// var frontCur=head;
// ListNode prev=null;
// var len=0;
// while(frontCur!=null)
// {
//     len+=1;
//     frontCur=frontCur.next;
// }
// int mod = len%2;
// int div=len/2;
// frontCur=head;
// ListNode nextNode=head.next;
//         
// for (int i = 0; i < div; i++)
// {
//     frontCur.next=prev;
//     prev= frontCur;
//     frontCur=nextNode;
//     nextNode=nextNode.next;
// }
// if (mod == 1) {
//     frontCur = frontCur.next;
// }
//
// while (frontCur != null )
// {
//     if (frontCur.val != prev.val) {
//         return false;
//     }
//     frontCur = frontCur.next;
//     prev = prev.next;
// }
//
// return true;