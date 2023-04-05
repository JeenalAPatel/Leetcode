using System.Collections.Generic;

namespace LeetCode
{
    public class LinkedListCycle
    {
        public ListNode listHead;

        public LinkedListCycle(List<int> list1)
        {
            var curr = new ListNode(0);
            listHead = curr;
            for (int i = 0; i < list1.Count; i++)
            {
                curr.next=new ListNode(list1[i]);
                curr = curr.next;
            }

            listHead = listHead.next;
        }
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            var slowRunner = head;
            var fastRunner = head.next;
            while (fastRunner?.next != null)
            {
                if (slowRunner == fastRunner)
                {
                    return true;
                }
                slowRunner = slowRunner.next;
                fastRunner = fastRunner.next?.next;
                
            }

            return false;
        }


        
    }
}