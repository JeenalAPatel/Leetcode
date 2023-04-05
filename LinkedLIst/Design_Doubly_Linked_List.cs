namespace  LeetCode
{
    public class DesignDoublyLinkedList
    {
        public ListNode head;
        public int Get(int index)
        {

            var cur = head;
            for (int i = 0; i < index && cur != null; i++)
            {
                cur = cur.next;
            }
        
            return cur?.val ?? -1;
        }
        public void AddAtHead(int val)
        {
            var newNode = new ListNode(val);

            if (head != null)
            {
                newNode.next = head;
                head.prev = newNode;
            }

            head = newNode;
        }
        public void AddAtTail(int val)
        {
            var newNode = new ListNode(val);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var curr = head;

                while (curr != null && curr.next != null)
                {
                    curr = curr.next;
                }

                curr.next = newNode;
                newNode.prev = curr;
            }


        }
        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
            }
            var cur = head;
            for (int i = 0; i < index - 1 && cur != null; i++)
            {
                cur = cur.next;
            }
            var newNode = new ListNode(val);
            newNode.prev = cur;
            newNode.next = cur.next;
            cur.next = newNode;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }


        }
        public void DeleteAtIndex(int index)
        {
            if (head == null)
            {
                return;
            }

            var cur = head;

            for (int i = 0; i < index && cur != null; i++)
            {
                cur = cur.next;
            }

            if (cur == null) return;
        
            var prev = cur.prev;
            var next = cur.next;

            if (prev != null) prev.next = next;
            if (next != null) next.prev = prev;

            if (index == 0)
            {
                head = next;
            }
        }
    }
    
}