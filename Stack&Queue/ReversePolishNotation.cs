using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class ReversePolishNotation
    {
        HashSet<String> set = new HashSet<string>();
        
        public ReversePolishNotation()
        {
            
            set.Add("+");
            set.Add("-");
            set.Add("*");
            set.Add("/");
        }
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            foreach (var item in tokens)
            {
                if (!set.Contains(item))
                {
                    stack.Push(int.Parse(item));
                }
                else if(item=="+")
                {
                    var ans = stack.Pop() + stack.Pop();
                    stack.Push(ans);
                }
                else if(item=="-")
                {
                    var temp = stack.Pop();
                    var ans = stack.Pop() - temp;
                    stack.Push(ans);
                }
                else if(item=="*")
                {
                    var ans = stack.Pop() * stack.Pop();
                    stack.Push(ans);
                }
                else if(item=="/")
                {
                    var temp = stack.Pop();
                    var ans = stack.Pop() / temp;
                    stack.Push(ans);
                }
                
            }
            return stack.Peek();
        }
        
    }
}