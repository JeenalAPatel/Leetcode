using System;
using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class InsertDeleteGetRandom
    {
        private Dictionary<int, int> dict = new Dictionary<int, int>();
        private List<int> list = new List<int>();
        
        public bool Insert(int val)
        {
            if (dict.ContainsKey(val)) return false;
            
            list.Add(val);
            dict.Add(val, list.Count - 1);
            return true;
        }

        public bool Remove(int val)
        {
            if (!dict.ContainsKey(val)) return false;

            var index = dict[val];
            list[index] = list[^1];
            dict[list[^1]] = index;
            list.RemoveAt(list.Count - 1);
            dict.Remove(val);
            
            return true;
        }

        public int GetRandom()
        {
            var length = dict.Count;
            Random rd = new Random();
            var index = rd.Next(length);
            return list[index];
        }
    }
}