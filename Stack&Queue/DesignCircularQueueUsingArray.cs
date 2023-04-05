using System.Collections.Generic;
namespace LeetCode
{
    public class DesignCircularQueueUsingArray
    
    {
        private readonly int[] _arr;
        private int _head;
        private int _tail;

            public DesignCircularQueueUsingArray(int k)
        {
            _arr = new int[k];
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            _arr[_tail % _arr.Length] = value;
            _tail += 1;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }

            _head += 1;
            if (IsEmpty())
            {
                _head = _tail = 0;
            }
            return true;
        }

        public int Front()
        {
            if (IsEmpty()) return -1;
            return _arr[_head % _arr.Length];
        }

        public int Rear()
        {
            if (IsEmpty()) return -1;
            return _arr[(_tail - 1) % _arr.Length];
        }

        public bool IsEmpty()
        {
            return _head == _tail;
        }

        public bool IsFull()
        {
            return _tail - _head == _arr.Length;
        }
    }
}