using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class DailyTemperatures
    {
        public int[] DailyTemperature(int[] T)
        {
            int[] ans = new int[T.Length];

            Stack<int> stack = new Stack<int>();
            for (int i = T.Length-1; i >= 0; i--)
            {
                while (stack.Count != 0 && T[i] >= T[stack.Peek()])
                {
                    stack.Pop();
                }
                ans[i] = stack.Count==0 ? 0 : stack.Peek() - i;
                stack.Push(i);
            }

            return ans;
        }

    } 
}