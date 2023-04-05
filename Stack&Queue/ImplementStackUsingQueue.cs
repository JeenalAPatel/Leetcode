using System.Collections.Generic;

namespace LeetCode
{
    public class ImplementStackUsingQueue
    {
        private Queue<int> queue1 = new Queue<int>();
        
        public ImplementStackUsingQueue()
        {
        }
    
        public void Push(int x) 
        {
            queue1.Enqueue(x);
            int queue1Count = queue1.Count;
            while (queue1Count > 1) {
                queue1.Enqueue(queue1.Dequeue());
                queue1Count--;
            }
            
        }
    
        public int Pop() 
        {
            return queue1.Dequeue();
           
        }
    
        public int Top()
        {
            return queue1.Peek();
        }
    
        public bool Empty()
        {
            return queue1.Count == 0;
        }
    }
}