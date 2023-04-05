using System;
using System.Collections.Generic;
namespace LeetCode
{
    public class MinStack
    {
        private Stack<int> stack = new Stack<int>();
        private Stack<int> minStack = new Stack<int>();
        public MinStack() {
        
        }
    
        public void Push(int x) {
            stack.Push(x);
            if (minStack.Count == 0)
            {
                minStack.Push(x);
            }
            else
            {
                if (x <= minStack.Peek())
                {
                    minStack.Push(x);
                }
            }
                
        }
    
        public void Pop()
        {
            if (stack.Count < 0)
            {
                return;
            }
            if (stack.Peek() == minStack.Peek())
            {
                minStack.Pop();
            }
            stack.Pop();
        }
    
        public int Top()
        {
            return stack.Peek();
        }
        
        public int GetMin()
        {
            return minStack.Peek();
        }   
    }
}