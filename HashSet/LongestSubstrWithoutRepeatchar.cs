using System;
using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class LongestSubstrWithoutRepeatChar
    {
        public int LengthOfLongestSubstring(string s) {
            int i = 0, j = 0, count = 0;
            var hashSet = new HashSet<char>();
            int len = s.Length;
            while (i < len)
            {
                if (!hashSet.Contains(s[i]))
                {
                    hashSet.Add(s[i]);
                    i++;
                    count = (count > hashSet.Count)? count : hashSet.Count;
                }
                else
                {
                    hashSet.Remove(s[j]);
                    j++;
                }
            }
            return count;
        }
    }
}