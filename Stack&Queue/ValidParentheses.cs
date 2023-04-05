using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class ValidParentheses
    {
        private Dictionary<char, char> brackets = new Dictionary<char, char>();
        private Stack<char> stackBracket = new Stack<char>();

        public ValidParentheses()
        {
            brackets.Add('[', ']');
            brackets.Add('(', ')');
            brackets.Add('{', '}');
        }

        public bool IsValid(string s)
        {
            foreach (var t in s)
            {
                if (brackets.ContainsKey(t))
                {
                    stackBracket.Push(t);
                }
                else if (stackBracket.TryPeek(out var result) && brackets[result] == t)
                {
                    stackBracket.Pop();
                }

                else
                {
                    return false;
                }
            }

            return stackBracket.Count == 0;
        }
    }
}