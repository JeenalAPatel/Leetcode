using System.Collections.Generic;

namespace LeetCode.HashSet
{
    public class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagramss(string[] strs) 
        {
            var list=new List<IList<string>>();
            var dict=new Dictionary<string,List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                
                char[] c = strs[i].ToCharArray();
                System.Array.Sort(c);
                var ans = string.Concat(c);
                if (dict.ContainsKey(ans))
                {
                    dict[ans].Add(strs[i]);
                }
                else
                {
                    dict.Add(ans,new List<string>(){strs[i]});
                }
                
            }

            foreach (var item in dict.Values)
            {
                list.Add(item);
            }
            return list;
        }
    }
}