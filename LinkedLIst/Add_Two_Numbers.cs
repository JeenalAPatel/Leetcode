using System.Collections.Generic;

namespace  LeetCode
{
    
    public class AddTwoNumbers
    {
        public ListNode? listHead1;
        public ListNode? listHead2;
        public AddTwoNumbers(List<int> list1,List<int> list2)
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

        public ListNode? AddTwoNumber(ListNode? l1, ListNode? l2) 
        {
            if (l1 == null && l2 == null)
            {
                return null;
            }

            var curr1 = l1;
            var curr2 = l2;
            var dummy = new ListNode(0);
            var curr3 = dummy;
            var carry = 0;
            
            while (curr1!=null || curr2!=null)
            {
                var sum = carry;
                
                if (curr1 != null)
                {
                    sum += curr1.val;
                }

                if (curr2 != null)
                {
                    sum += curr2.val;
                }

                carry = sum / 10;
                var val = sum % 10;
                var node = new ListNode(val);
                curr1 = curr1?.next;
                curr2 = curr2?.next;
                curr3.next = node;
                curr3 = curr3.next;
            }

            if (carry > 0)
            {
                curr3.next = new ListNode(carry);
            }
            
            return dummy.next;
        }
    }
    
}