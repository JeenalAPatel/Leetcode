using System.Collections.Generic;

namespace LeetCode
{
    public class ImplementQueueUsingStack
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();
        private int front;
        public ImplementQueueUsingStack()
        {
            front = 0;
        }
    
        public void Push(int x) 
        {
            if (stack.Count == 0)
            {
                front = x;
            }
            stack.Push(x);
            
        }
    
        public int Pop() 
        {
            if (stack2.Count == 0)
            {
                while (stack.Count!=0)
                {
                    stack2.Push(stack.Pop());
                }
            }

            return stack2.Pop();
        }
    
        public int Peek()
        {
            if (stack2.Count != 0)
            {
                return stack2.Peek();
            }

            return front;
        }
    
        public bool Empty()
        {
            return (stack.Count == 0) && (stack2.Count == 0);
        }
    }
}