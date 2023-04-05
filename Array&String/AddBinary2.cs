using System;
using System.Collections.Generic;

namespace LeetCodeArray
{
    public class AddBinary2
    {
        private (char res, char carry) Add(char a, char b, char carry)
        {
            var sum = 0;
            if (a == '1')
            {
                sum += 1;
            }

            if (b == '1')
            {
                sum += 1;
            }

            if (carry == '1')
            {
                sum += 1;
            }

            return sum switch
            {
                0 => ('0', '0'),
                1 => ('1', '0'),
                2 => ('0', '1'),
                _ => ('1', '1')
            };
        }
        // var A = a.Length - 1 - i < 0 ? '0' : a[a.Length - 1 - i];
        // var B = b.Length - 1 - i < 0 ? '0' : b[b.Length - 1 - i];
        private char GetCharAtIndex(string str, int index)
        {
            var indexToGet = str.Length - 1 - index;

            if (indexToGet < 0)
            {
                return '0';
            }
            else
            {
                return str[indexToGet];
            }
        }
        
        public string AddBinary(string a, string b)
        {
            var n = a.Length;
            var m = b.Length;

            int len = Math.Max(n, m);

            var carry = '0';

            var result = new List<char>();

            for (int i = 0; i < len; i++)
            {
                var e1 = GetCharAtIndex(a, i);
                var e2 = GetCharAtIndex(b, i);
                var (res, c) = Add(e1, e2, carry);
                carry = c;
                result.Add(res);
            }

            if (carry == '1')
            {
                result.Add('1');
            }

            result.Reverse();

            return string.Join("", result);
        }
    }
}