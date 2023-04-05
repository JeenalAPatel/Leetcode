using System.Collections.Generic;

namespace LeetCode
{
    public class LinkedListCycle2
    {
        public ListNode listHead;
        public LinkedListCycle2(List<int> list1)
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

        public ListNode? DetectCycle(ListNode? head) 
        {
            if(head==null)
                return null;
            var intersect = getIntersect(head);
            if(intersect==null)
                return null;
            var ptr1=head;
            var ptr2=intersect;
            while(ptr1!=ptr2)
            {
                ptr1=ptr1?.next;
                ptr2=ptr2?.next;

            }
            return ptr1;
        }
        public ListNode? getIntersect(ListNode? head)
        {
            var slowRunner = head;
            var fastRunner = head;

            while (fastRunner != null && fastRunner.next != null)
            {
                fastRunner = fastRunner.next.next;
                slowRunner = slowRunner?.next;
                if (slowRunner == fastRunner) {
                    return fastRunner;
                }
            }

            return null;
        }
    }
}