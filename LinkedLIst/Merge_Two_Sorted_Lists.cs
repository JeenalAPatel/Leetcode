using System.Collections.Generic;

namespace LeetCode
{
    public  class ListNode
    {
        public int val;
        public ListNode? next, prev;

        public ListNode(int x)
        {
            val = x;
        }

    }

    public class MyLinkedList
    {
        public ListNode? listHead1;
        public ListNode? listHead2;
        public MyLinkedList(List<int> list1, List<int> list2)
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

        public ListNode? MergeTwoLists(ListNode? l1, ListNode? l2)
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }
            var curr1 = l1;
            var curr2 = l2;
            ListNode dummy = new ListNode(0);
            ListNode curr3 = dummy;
            while (curr2 != null && curr1!=null)
            {
                if (curr2.val <= curr1.val)
                {
                    curr3.next = curr2;
                    curr2 = curr2.next;
                }
                else if(curr1.val<curr2.val)
                {
                   
                    curr3.next = curr1;
                    curr1 = curr1.next;
                }

                curr3 = curr3.next;
            }

            if (curr2 == null)
            {
                curr3.next = curr1;
            }
            else
            {
                curr3.next = curr2;
            }

            return dummy.next;
        }
    }
}