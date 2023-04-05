using System.Collections.Generic;

namespace LeetCode
{
    public class ListtNode
    {
        public int val;
        public ListtNode? next;

        public ListtNode(int x)
        {
            val = x;
        }
    }

    public class RotateList
    {
        public ListtNode listHead;

        public RotateList(List<int> List1)
        {
            var curr = new ListtNode(0);
            listHead = curr;
            for (int i = 0; i < List1.Count; i++)
            {
                curr.next = new ListtNode(List1[i]);
                curr = curr.next;
            }

            listHead = listHead.next;
        }

        public ListtNode? RotateRight(ListtNode? head, int k)
        {
            if (head == null)
            {
                return null;
            }

            var len = 0;
            var pointer = head;
            while (pointer != null)
            {
                len += 1;
                pointer = pointer.next;
            }

            var mod = k % len;
            
            if (mod == 0)
            {
                return head;
            }

            var counter = 0;
            var curr = head;
            var prevHead = head;
            
            while (counter < (len - mod - 1))
            {
                curr = curr?.next;
                counter += 1;
            }

            var newHead = curr.next;
            var tail = newHead;

            while (tail.next != null && tail!=null)
            {
                tail = tail.next;
            }

            tail.next = prevHead;
            curr.next = null;
            head = newHead;
            
            return head;
        }
    }
}
// if (head == null)
//     return null;
// var cur = head;
// var len = 0;
// while (cur!=null)
// {
//     cur = cur.next;
//     len += 1;
// }
//
// cur = head;
// k = k % len;
// var diff = len - k;
// for (int i = 0; i < diff-1; i++)
// {
//     cur = cur.next;
// }
//
// var end = cur;
// var newHead = cur.next;
// while (cur?.next!=null)
// {
//     cur = cur.next;
// }
//
// cur.next = head;
// end.next = null;
// return newHead;