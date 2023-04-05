using System.Collections.Generic;

namespace LeetCode
{
    public class IntersectionOfTwoLinkedLists
    {
        public ListNode listHead1;
        public ListNode listHead2;
        public IntersectionOfTwoLinkedLists(List<int>list1,List<int>list2)
        {
            var curr1 = new ListNode(0);
            var curr2 = new ListNode(0);
            listHead1 = curr1;
            listHead2 = curr2;
            for (int i = 0; i < list1.Count; i++)
            {
                curr1.next = new ListNode(list1[i]);
                curr1 = curr1.next;
            }
            for (int i = 0; i < list2.Count; i++)
            {
                curr2.next = new ListNode(list2[i]);
                curr2 = curr2.next;
            }

            listHead1 = listHead1.next;
            listHead2 = listHead2.next;
        }

        public ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            var curr1 = headA;
            var curr2 = headB;
            var len1 = 0;
            var len2 = 0;
            while (curr1!=null)
            {
                curr1 = curr1.next;
                len1 += 1;
            }
            while (curr2!=null)
            {
                curr2 = curr2.next;
                len2 += 1;
            }

            curr1 = headA;
            curr2 = headB;
            if (len1 > len2)
            {
                var diff = len1 - len2;
                for (int i = 0; i < diff; i++)
                {
                    curr1 = curr1?.next;
                }
            }
            else
            {
                var diff = len2 - len1;
                for (int i = 0; i < diff; i++)
                {
                    curr2 = curr2?.next;
                }
            }

            while (curr1!=curr2)
            {
                curr1 = curr1?.next;
                curr2 = curr2?.next;
                if (curr1 == curr2)
                {
                    return curr1;
                }
            }

            return null;
        }
    }
}
