using System.Collections.Generic;

namespace LeetCode
{
    public class CNode
    {
        public int val;
        public CNode next;

        public CNode(int _val)
        {
            val = _val;
            next = null;
        }

        public CNode(int _val, CNode _next)
        {
            val = _val;
            next = _next;
        }
    }

    public class InsertIntoACyclicSortedList
    {
        public CNode listHead;

        public InsertIntoACyclicSortedList(List<int> list1)
        {
            var curr = new CNode(0);
            listHead = curr;
            for (int i = 0; i < list1.Count; i++)
            {
                curr.next = new CNode(list1[i]);
                curr = curr.next;
            }

            listHead = listHead.next;
            curr.next = listHead;
        }

        public CNode? Insert(CNode? head, int insertVal)
        {
            if (head == null)
            {
                head = new CNode(insertVal);
                head.next = head;
                return head;
            }

            CNode curr = head;
            while (true)
            {
                if ((curr.val <= insertVal && insertVal <= curr.next.val) || (curr.next == head && curr.val==head.val) ||
                    ((insertVal >= curr.val || insertVal<=curr.next.val) && curr.next.val < curr.val))
                {
                    var newNode = new CNode(insertVal);
                    newNode.next = curr.next;
                    curr.next = newNode;
                    return head;
                }
                

                curr = curr.next;
            }
            
            
        }
    }
}