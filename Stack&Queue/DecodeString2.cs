using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
namespace LeetCode
{
    public class DecodeString2
    {
        public string DecodeString(string s)
        {
            var stack = new Stack<char>();
            var charList = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ']')
                {
                    while (stack.Peek() != '[')
                    {
                        charList.Add(stack.Pop());
                    }

                   
                    stack.Pop();
                    var num = 0;
                    var digitIndex = 0;
                    while (stack.TryPeek(out var result) && char.IsDigit(result))
                    {
                        num+=int.Parse(stack.Pop().ToString())*(int)Math.Pow(10,digitIndex);
                        digitIndex += 1;
                    }
                    
                    while (num>0)
                    {
                        for (int j = charList.Count-1; j >=0; j--)
                        {
                            stack.Push(charList[j]);
                        }
                        
                        num--;
                    }

                    charList.Clear();
                    
                    
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            return string.Join("", stack.Reverse().ToArray());
        }
    }
}