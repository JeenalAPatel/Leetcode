using System.Collections.Generic;

namespace LeetCode
{
    public class NodeQueue
    {
        public int value;
        public NodeQueue nextNode;

        public NodeQueue(int value)
        {
            this.value = value;
            this.nextNode = null;
        }
    }

    public class DesignCircularQueue
    {

        private NodeQueue? head, tail;
        private int count;
        private int capacity;

        public DesignCircularQueue(int k)
        {
            this.capacity = k;
        }

        public bool EnQueue(int value)
        {
            if (this.count == this.capacity)
                return false;

            NodeQueue newNode = new NodeQueue(value);
            if (this.count == 0)
            {
                head = tail = newNode;
            }
            else
            {
                tail.nextNode = newNode;
                tail = newNode;
            }

            tail.nextNode = head;
            this.count += 1;
            return true;
        }

        public bool DeQueue()
        {
            if (this.count == 0)
                return false;
            this.head = this.head.nextNode;
            tail.nextNode = head;
            this.count -= 1;
            return true;
        }

        public int Front()
        {
            if (this.count == 0)
                return -1;
            else
                return this.head.value;
        }

        public int Rear()
        {
            if (this.count == 0)
                return -1;
            else
                return this.tail.value;
        }

        public bool IsEmpty()
        {
            return (this.count == 0);
        }

        public bool IsFull()
        {
            return (this.count == this.capacity);
        }
    }
}
