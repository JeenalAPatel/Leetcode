using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCodeArray
{
    public class ReverseWordsInAString
    {
        
        public string ReverseWords(string s)
        {
            var str = "";
            s = s.Trim();
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length-1; i >=0; i--)
            {
                if (char.IsWhiteSpace(s[i]) && sb.Length > 0)
                {
                    str += string.Join("",sb.ToString().Reverse()) + " ";
                     sb.Clear();
                    
                }
                else if (!char.IsWhiteSpace(s[i]))
                {
                    sb.Append(s[i]);
                }
            }
            str += string.Join("",sb.ToString().Reverse());
            return str;
        }

        public string ReverseWords2(string s)
        {
            s = s.Trim();
            var reg = new Regex(@"\s+");
            s = reg.Replace(s, " ");
            return string.Join(" ",s.Split().Reverse());
        }

        public string ReverseWords3(string s)
        {
            s = s.Trim();
            var arr = s.ToCharArray();
            ReverseChars(arr, 0, arr.Length - 1);
            var start = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(arr[i])) continue;
                ReverseChars(arr, start, i - 1);
                start = i + 1;
            }

            if (start < arr.Length - 1)
            {
                ReverseChars(arr, start, arr.Length - 1);
            }

            return string.Join("", arr);
        }

        public void ReverseChars(char[] arr, int start, int end)
        {
            while (start < end)
            {
                var temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start += 1;
                end -= 1;
            }
        }
    }
}