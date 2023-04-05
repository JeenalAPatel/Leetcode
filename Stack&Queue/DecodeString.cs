using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class DecodeString
    {
        
        public string DecodeStrings(string s)
        {
            var stack = new Stack<char>();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ']')
                {var str = "";
                    while (stack.Peek()!='[')
                    {
                        str = stack.Pop() + str;
                    }
                    stack.Pop();
                    var list = new List<char>();
                    while(stack.TryPeek(out var res) && char.IsDigit(res))
                    {
                        list.Add(stack.Pop());
                    }

                    list.Reverse();
                    var num = int.Parse(string.Join("", list));
                    for (int j = 0; j < num; j++)
                    {
                        foreach (var ch in str)
                        {
                            stack.Push(ch);
                        }
                    }

                }
                else
                {
                    stack.Push(s[i]);
                }
               
            }

            return string.Join("", stack.Reverse());
        }
    }
}