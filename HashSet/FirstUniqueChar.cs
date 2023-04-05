using System.Collections.Generic;
using System.Linq;

namespace LeetCode.HashSet
{
    public class FirstUniqueChar
    {
        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]]=s.Length+1;
                }
                else
                {
                    dict.Add(s[i],i);
                }
                
            }

            if (dict.Count >0 && dict.Values.Min()!=s.Length+1)
            {
                
                return dict.Values.Min();
            }
           
          
            return -1;
        }
    }
}