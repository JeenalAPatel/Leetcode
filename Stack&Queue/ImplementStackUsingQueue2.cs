using System.Collections.Generic;

namespace LeetCode
{
    public class ImplementStackUsingQueue2
    {
        private Queue<int> queue1 = new Queue<int>();
        private Queue<int> queue2 = new Queue<int>();
        private int top;
        public ImplementStackUsingQueue2() {
        
        }
    
        public void Push(int x)
        {
            queue1.Enqueue(x);
            top = x;
        }

        public int Pop()
        {
            while (queue1.Count>1)
            {
                top=queue1.Dequeue();
                queue2.Enqueue(top);
            }

            var del=queue1.Dequeue();
            var temp = queue1;
            queue1 = queue2;
            queue2 = temp;
            return del;
        }

        public int Top()
        {
            return top;
        }

        public bool Empty()
        {
            return (queue2.Count == 0 && queue1.Count==0);
        }
    }
}