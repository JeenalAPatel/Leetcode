namespace LeetCode
{
    public class DesignSinglyLinkedList
    {
        public ListNode? head;
        public int size;

        public DesignSinglyLinkedList()
        {
            size = 0;
        }

        public int Get(int index)
        {
            var curr = head;
            if (index >= size)
            {
                return -1;
            }

            for (int i = 0; i < index && curr != null; i++)
            {
                curr = curr.next;
            }

            return curr?.val ?? -1;
        }

        public void AddAtHead(int val)
        {
            size += 1;
            var curr = new ListNode(val);
            curr.next = head;
            head = curr;
            return;
        }

        public void AddAtTail(int val)
        {
            if (head == null)
            {
                AddAtHead(val);
                return;
            }

            size += 1;
            var curr = head;
            while (curr != null && curr.next != null)
            {
                curr = curr.next;
            }

            var newNode = new ListNode(val);
            curr.next = newNode;
        }

        public void AddAtIndex(int index, int val)
        {
            if (head == null || index == 0)
            {
                AddAtHead(val);
                return;
            }

            size += 1;
            var curr = head;
            for (int i = 0; i < index - 1 && curr != null; i++)
            {
                curr = curr.next;
            }

            var newNode = new ListNode(val);
            newNode.next = curr?.next;
            if (curr != null) curr.next = newNode;
        }

        public void DeleteAtIndex(int index)
        {
            if (head == null || index >= size)
            {
                return;
            }

            if (index == 0)
            {
                head = head.next;
                size -= 1;
                return;
            }

            size -= 1;
            var curr = head;
            for (int i = 0; i < index - 1 && curr != null; i++)
            {
                curr = curr.next;
            }

            curr.next = curr?.next?.next;
        }
    }
}